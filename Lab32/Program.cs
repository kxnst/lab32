using System;
using System.Collections.Generic;
using Lab32.Classes;
namespace Lab32
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Goods> goods = new List<Goods>();
            for(int i = 0; i < 10; i++)
            {
                goods.Add(Goods.CreateRandom());
            }
            goods.Remove(goods[rand.Next(0,goods.Count)]);
            goods[2].Expiration = DateTime.Now.AddDays(-4);
            bool isExpired = goods[2].IsExpired();
            BinTree<Goods> tree = new BinTree<Goods>();
            tree.InsertFromArray(goods.ToArray());
            tree.InOrderTraversal(tree.Root);   
        }
    }
}
