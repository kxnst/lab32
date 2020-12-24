using System;
using System.Collections.Generic;
using System.Text;

namespace Lab32.Classes
{
    public class BinTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

        public void InOrderTraversal(Node<T> Node)
        {
            if (Node != null)
            {
                InOrderTraversal(Node.Left);
                Console.WriteLine(Node.Data.ToString());
                InOrderTraversal(Node.Right);

            }
        }
        public void Insert(T Data, Node<T> Node)
        {

            if (Data.CompareTo(Node.Data) > 0)
            {
                if (Node.Right == null)
                {
                    Node.Right = new Node<T>(Data);
                    return;
                }
                Insert(Data, Node.Right); //Вставка
                System.Console.WriteLine("right");
            }

            else if (Data.CompareTo(Node.Data) < 0)
            {
                if (Node.Left == null)
                {
                    Node.Left = new Node<T>(Data);
                    return;
                }
                Insert(Data, Node.Left);
                System.Console.WriteLine("left");
            }
        }

        public void Insert(T Data)
        {
            if (Root == null)
            {
                Root = new Node<T>(Data);
            }

            Node<T> Current = Root;

            while (Current != null)
            {
                if (Data.CompareTo(Current.Data) > 0)
                {
                    if (Current.Right != null)
                    {
                        Current = Current.Right;
                        continue;
                    }
                    Current.Right = new Node<T>(Data);
                }

                else if (Data.CompareTo(Current.Data) < 0)
                {
                    if (Current.Left != null)
                    {
                        Current = Current.Left;
                        continue;
                    }
                    Current.Left = new Node<T>(Data);
                }

                else
                {
                    return;
                }

            }
        }
        public void InsertFromArray(T[] array)
        {
            foreach (T t in array)
            {
                this.Insert(t);
            }
        }
    }
}
