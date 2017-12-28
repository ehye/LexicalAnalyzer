using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyComplier
{
    class LexAnalyser
    {
        // 保留字
        private string[] reservedWords = new string[] {"if","then","auto","short", "int", "long",
        "float","double","char" ,"struct","union","enum","typedef", "const","unsigned","signed",
            "extern","register","static","volatile","void ","if","else","switch","case","for",
            "do","while", "goto" ,"continue","break","default","sizeof","return"};
        // 数学运算符
        private string[] operatorSymbols = new string[] { "+", "-", "*", "/", "%", "=", "<", ">", "<=", ">=", "=", "-=", "+=", "*=", "/=" };
        // 终结符
        private string[] delimiter = { "(", ")", "{", "}", "[", "]", "'", ";", "," };

        private List<Symbol> tokens_list;

        // 源程序文件输入流
        private string sourceFilePath;
        private RichTextBox Txt_lex;
        private RichTextBox Txt_error;
        // 代码行数
        private int lineCount = 0;

        internal List<Symbol> Tokens_list { get => tokens_list; private set => tokens_list = value; }

        /// <summary>
        /// 创建词法分析器
        /// </summary>
        /// <param name="sourceFilePath">源文件路径</param>
        /// <param name="Txt_lex">输出到的控件</param>
        public LexAnalyser(string sourceFilePath, RichTextBox Txt_lex, RichTextBox Txt_error)
        {
            this.sourceFilePath = sourceFilePath;
            this.Txt_lex = Txt_lex;
            this.Txt_error = Txt_error;
        }
        /// <summary>
        /// 逐行扫描源程序代码
        /// 一次循环读一行
        /// </summary>
        public void Scan()
        {
            string sourceLine = "";
            string[] tokens;
            tokens_list = new List<Symbol>();

            using (StreamReader sr = new StreamReader(sourceFilePath))
            {
                while ((sourceLine = sr.ReadLine()) != null)
                {
                    lineCount++;
                    int delimiter_status = 1;
                    Txt_lex.Text += $"{lineCount}: {sourceLine}\n";

                    // 获取每一行的Token集合
                    tokens = GetTokens(sourceLine);

                    foreach (var token in tokens)
                    {
                        //int thisNum = 0;
                        // 跳过行注释符
                        if (token.Equals("//")) break;
                        // 保留字
                        else if (IsReservedWord(token))
                        {
                            Txt_lex.Text += $"    {token}    <reserved word>\n";
                            tokens_list.Add(new Symbol(lineCount, token, "ReservedWord"));
                        }
                        // 终结符
                        else if (IsDelimiter(token))
                        {
                            delimiter_status *= -1;
                            Txt_lex.Text += $"    {token}    <delimiter>\n";
                            tokens_list.Add(new Symbol(lineCount, token, "Delimiter"));
                        }
                        // 运算符
                        else if (IsOperator(token))
                        {
                            Txt_lex.Text += $"    {token}    <operator>\n";
                            tokens_list.Add(new Symbol(lineCount, token, "Operator"));
                        }
                        // 整数
                        else if (IsInt(token, out int thisInt))
                        {
                            // 如果小于零，取相反数
                            if (thisInt < 0)
                            {
                                int t = thisInt *= -1;
                                Txt_lex.Text += $"    -    <operator>\n    {thisInt *= -1}    <integer>\n";
                                tokens_list.Add(new Symbol(lineCount, "-", "Operator"));
                                tokens_list.Add(new Symbol(lineCount, t.ToString(), "Integer"));
                            }
                            else
                            {
                                Txt_lex.Text += $"    {thisInt}    <integer>\n";
                                tokens_list.Add(new Symbol(lineCount, thisInt.ToString(), "Integer"));
                            }
                        }
                        // 浮点数
                        else if (IsFloat(token, out float thisF))
                        {
                            // 如果小于零，取相反数
                            if (thisF < 0)
                            {
                                float t = thisF *= -1;
                                Txt_lex.Text += $"    -    <operator>\n    {thisF *= -1}    <float>\n";
                                tokens_list.Add(new Symbol(lineCount, "-", "Operator"));
                                tokens_list.Add(new Symbol(lineCount, t.ToString(), "Integer"));
                            }
                            else
                            {
                                Txt_lex.Text += $"    {thisF}    <float>\n";
                                tokens_list.Add(new Symbol(lineCount, thisF.ToString(), "Float"));
                            }
                        }
                        // 自定义标识符
                        // 或处理未用空格分割的 token
                        else
                        {
                            string output = String.Empty;
                            for (int i = 0; i < token.Length; i++)
                            {
                                // 是字母或数字
                                if (IsAlpha(token[i]) || IsInt(token[i].ToString(), out thisInt))
                                    output += token[i];
                                else if (IsDelimiter(token[i].ToString()))
                                {
                                    // 若已有生成则输出并清空输出区
                                    if (!String.IsNullOrEmpty(output))
                                    {
                                        Txt_lex.Text += $"    {output}    <id>\n";
                                        tokens_list.Add(new Symbol(lineCount, output, "ID"));
                                        output = String.Empty;
                                    }
                                    // 输出这个字符
                                    delimiter_status *= -1;
                                    Txt_lex.Text += $"    {token[i]}    <delimiter>\n";
                                    tokens_list.Add(new Symbol(lineCount, token[i].ToString(), "Delimiter"));

                                    // 最后是分号
                                    if (token[i].Equals(";"))
                                    {
                                        output = ";";
                                        Txt_lex.Text += $"    {output}    <delimiter>\n";
                                        tokens_list.Add(new Symbol(lineCount, output, "Delimiter"));
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("无法识别");
                                }
                            }
                            if (!String.IsNullOrEmpty(output)) Txt_lex.Text += $"    {output}    <id>\n";
                        }
                    }

                    if (delimiter_status == 1)
                    {
                        Txt_error.Text += $"Error - Line {lineCount}: \n";
                        Console.WriteLine("出错");
                    }
                }
            }
        }

        /// <summary>
        /// 判断是否为字母
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsAlpha(char ch)
        {
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 判断是否为保留字 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsReservedWord(string token)
        {
            foreach (var r in reservedWords)
                if (token.Equals(r)) return true;
            return false;
        }
        /// <summary>
        /// 判断是否为运算符
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsOperator(string token)
        {
            foreach (var o in operatorSymbols)
                if (token.Equals(o)) return true;
            return false;
        }
        ///<summary>
        ///判断是否为数值NUM
        ///</summary>
        private bool IsInt(string token, out int r)
        {
            bool result = int.TryParse(token, result: out int thisInt);
            r = thisInt;
            return result;
        }
        /// <summary>
        /// 判断是否为浮点数
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsFloat(string token, out float r)
        {
            bool result = float.TryParse(token, out float thisF);
            r = thisF;
            return result;
        }
        ///<summary>
        ///判断是否为ID
        ///</summary>
        private bool IsID(string token)
        {
            return Regex.IsMatch(@"\d+?", token);
        }
        /// <summary>
        /// 判断是否为终结符
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsDelimiter(string token)
        {
            foreach (var d in delimiter)
                if (token.Equals(d)) return true;
            return false;
        }
        /// <summary>
        /// 用空格式将每一行源代码拆分成单个 Token 的集合 
        /// </summary>
        public string[] GetTokens(string sourceLine)
        {
            Regex pattern = new Regex(" ");
            return pattern.Split(sourceLine);
        }

    }
}
