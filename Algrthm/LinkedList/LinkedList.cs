using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Counter { get; private set; }

        public void AddNodeToLast(Node<T> node)
        {
            if(node!=null)
            {
                if(Counter==0)
                {
                    Head = node;
                    Tail = Head;
                    Counter++;
                }
                else
                {
                    Tail.Next = node;
                    Tail = node;
                    Counter++;
                }

            }
        }

        public void AddNodeToFirst(Node<T> node)
        {
            if (node != null)
            {
                if (Counter == 0)
                {
                    Head = node;
                    Tail = Head;
                    Counter++;
                }
                else
                {
                    node.Next = Head;
                    Head = node;
                    Counter++;
                }
            }
        }

        public void RemoveNodeAtFirst()
        {
            Node<T> temp;
            if (Counter != 0)
            {
                temp = Head.Next;
                Head = null;
                Head = temp;
                Counter--;
            }
        }

        public void RemoveNodeAtLast()
        {

            if (Counter != 0)
            {
                Node<T> node = Head;
                Node<T> temp=node;

                if(Head == Tail)
                {
                    Head = Tail = null;
                    return;
                }

                while (node != null)
                {
                    if(node!=Tail)
                    {
                        temp = node;
                        node = node.Next;
                    }
                    else
                    {
                        Tail = temp;
                        Tail.Next = null;
                    }
                    
                }
            }
        }

    }
}
