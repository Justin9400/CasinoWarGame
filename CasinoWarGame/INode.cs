using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public interface INode//<Type> : IEnumerable<Type> where Type : IComparable<Type>
    {
        Card card { get; set; }
        INode next { get; set; }
    }
}
