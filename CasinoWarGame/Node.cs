using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public class Node : INode //<Type> where Type : IComparable<Type>
    {
        public Card card { get; set; }
        public INode next { get; set; }

        public Node(Card Card, INode Next = null)
        {
            this.card = Card;
            this.next = Next;
        }

        //public IEnumerator<Type> GetEnumerator()
        //{
        //    INode currentNode = this;
        //    while (currentNode != null)
        //    {
        //        yield return currentNode.card;
        //        currentNode = currentNode.next;
        //    }
        //}
    }
}
