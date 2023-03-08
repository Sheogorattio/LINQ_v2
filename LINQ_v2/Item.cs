using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemClass
{
    public class Item
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public double Price { get; set; }

        public Item() { }
        public Item(string name, string producer, double price)
        {
            Name = name;
            Producer = producer;
            Price = price;
        }
        public override string ToString() { return  Name; }
        public static IEnumerable<Item> GetDifference(Item[] minuend, Item[] subtrahend) 
        {
            return minuend.Except(subtrahend);
        }
        public static IEnumerable<Item> GetIntersection(Item[] set1, Item[] set2)
        {
            return set1.Intersect(set2);
        }
        public static IEnumerable<Item> GetUnion(Item[] set1, Item[] set2)
        {
            return set1.Union(set2);
        }

        //public int Compare(Item x, Item y)
        //{
        //    return x.Producer.CompareTo(y.Producer);
        //}
    }
}
