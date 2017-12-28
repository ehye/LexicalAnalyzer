using System.IO;
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
        private string[] operatorSymbols = new string[] { "+", "-", "*", "/", "%", "=", "<", ">", "<=", ">=", "=" };
        // 终结符
        private string[] delimiter = { "(", ")", "{", " }", "[", "]", " '", ";", "," };

        // 源程序文件输入流
        private string sourceFilePath;
        private RichTextBox Txt_lex;
        // 代码行数
        private int lineCount = 0;

        /// <summary>
        /// 创建词法分析器
        /// </summary>
        /// <param name="sourceFilePath">文件路径</param>
        /// <param name="Txt_lex">输出控件</param>
        public LexAnalyser(string sourceFilePath, RichTextBox Txt_lex)
        {
            this.sourceFilePath = sourceFilePath;
            this.Txt_lex = Txt_lex;
        }
        /// <summary>
        /// 逐行扫描源程序代码
        /// 一次循环读一行
        /// </summary>
        public void Scan()
        {
            string sourceLine = "";
            string[] tokens;

            using (StreamReader sr = new StreamReader(sourceFilePath))
            {
                while ((sourceLine = sr.ReadLine()) != null)
                {
                    lineCount++;
                    Txt_lex.Text += $"{lineCount}: {sourceLine}\n";
                    // 获取每一行的Token集合
                    tokens = GetTokens(sourceLine);

                    int size = tokens.Length;
                    foreach (var t in tokens)
                    {
                        // 保留字
                        if (IsReservedWord(t))
                            Txt_lex.Text += $"    {t}    <reserved word>\n";
                        // 终结符
                        else if (IsDelimiter(t))
                            Txt_lex.Text += $"    {t}    <delimiter>\n";
                        // 运算符
                        else if (IsOperator(t))
                            Txt_lex.Text += $"    {t}    <operator>\n";
                        // 整数
                        else if (IsInt(t))
                            Txt_lex.Text += $"    {t}    <integer>\n";
                        // 浮点数
                        else if (IsFloat(t))
                            Txt_lex.Text += $"    {t}    <float>\n";
                        // 标识符
                        else if (IsID(t))
                            Txt_lex.Text += $"    {t}    <id>\n";
                        // 跳过行注释符
                        else if (t.Equals("//")) break;
                        // 未知字符
                        else Txt_lex.Text += $"    {t}    <UNKNOW>\n";
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
        private bool IsInt(string token)
        {
            return int.TryParse(token, out int r);
            //return Regex.IsMatch(@"^(\+|-)?\d+$", token);
        }
        /// <summary>
        /// 判断是否为浮点数
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool IsFloat(string token)
        {
            return float.TryParse(token, out float r);
            //return Regex.IsMatch(@"(([1-9][0-9]*\.?[0-9]*)|(\.[0-9]+))([Ee][+-]?[0-9]+)?", token);
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
