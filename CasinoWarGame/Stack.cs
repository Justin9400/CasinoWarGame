using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public class Stack //: IStack
    {
        public int count { get; set; }
        public  INode _top { get; set; }
        public Card card { get; set; }

        public Stack()
        {
            _top = null;
        }
        public void push(Card card)
        {
            //Create new node to push to the stack 
            INode newNode = new Node(card);
            if (_top == null) //If the stack is empty
            {
                _top = newNode;
            }
            else
            {
                newNode.next = _top; //Set newNodes next to the previous top of the stack
                _top = newNode; //Set the top as the new node that was added
            }
            count++;
        }

        public Card pop()
        {
            if (_top == null) //If the stack is null
            {
                throw new NullReferenceException();
            }
            else
            {
                card = _top.card; //Get the card to return
                _top = _top.next; //Move the top one node down
                count--; //Decrement the size of the stack
            }
            return card;
        }

        public Card peek()
        {
            return _top.card;
        }

        public int size()
        {
            return count;
        }

        //public void printDeck()
        //{
        //    INode<Type> currentNode = _top;
        //    while (currentNode != null)
        //    {
        //        Console.WriteLine(currentNode.item);
        //        currentNode = currentNode.next;
        //    }
        //}
    }
}
