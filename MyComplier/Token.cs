using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplier
{
    enum Token
    {
        ReservedWord = 1,
        Operator = 2,
        Delimiter = 3,
        ID = 4,
        Integer = 5,
        Float = 6,
    }
}
