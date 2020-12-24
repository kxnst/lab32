using System;
using System.Collections.Generic;
using System.Text;

namespace Lab32.Classes
{
    public class Node<T> where T : IComparable
    {
        public Node(T Data)
        {
            this.Data = Data;
        }
        public Node() { }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public T Data { get; set; }
    }
}
