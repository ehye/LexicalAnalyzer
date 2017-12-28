using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplier
{
    class Symbol
    {
        private int line;       // 行号
        private string name;    // 变量名
        private int tokenId;    // tkoen 值
        private string type;    // 变量类型
        private List<string> table = new List<string>
        {
            "int",
            "float",
            "double",
            "boolean",
            "Char",
            "const",
            "if",
            "else",
            "while",
            "do",
            "for",
            "&&",
            "||",
            "+",
            "-",
            "*",
            "<",
            ">",
            "<=",
            ">=",
            "=",
            ";",
            ",",
            "'",
            "\"",
            "//",
            "/*",
            "*/",
            "(",
            ")",
            "{",
            "}",
            ".",
            ":",
            "Integer",
            "Float",
            "Double"
        };

        public string Name { get => name; set => name = value; }
        public int Line { get => line; set => line = value; }
        public string Type { get => type; set => type = value; }
        public int TokenId { get => tokenId; set => tokenId = value; }
        public List<string> Table { get => table; set => table = value; }

        public Symbol(int line, string name, string type)
        {
            this.line = line;
            this.name = name;
            this.type = type;
            if (type == "Float" || type == "Double" || type == "Char" || type == "Integer")
            {
                tokenId = table.IndexOf(type);
            }
            else
            {
                tokenId = table.IndexOf(name);
            }
        }

        public override string ToString() => $"{line}\t{name}\t{tokenId}\t{type}";
    }
}
