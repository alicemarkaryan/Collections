using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        class A
        {
            public int Id;
            public string name;
        }
        static void Main(string[] args)
        {
            List<A> list = new List<A>();
            
            list.Add(new A { Id = 1, name = "Ani" });
            list.Add(new A {Id = 2, name = "Armen"});
            list.Add(new A { Id = 3, name = "Alice"});
            list.Add(new A { Id = 3, name = "Alice" });
            list.RemoveAt(1);
            Console.WriteLine(list.Capacity);
            foreach(A li in list)
            {
                Console.WriteLine(li.Id+" = "+li.name);
            }

            LinkedList<int> linkList = new LinkedList<int>();
            linkList.AddFirst(5);
            linkList.AddFirst(4);
            linkList.AddFirst(3);
            linkList.AddFirst(2);
            linkList.AddFirst(1);
            foreach(int num in linkList)
            {
                Console.WriteLine(num);
            }
            linkList.Remove(4);
            foreach (int num in linkList)
            {
                Console.WriteLine(num);
            }

            ArrayList arrList = new ArrayList();
            arrList.Add("barev");
            arrList.Add("bolor");
            arrList.Add("ev");
            arrList.Add("hayerin");
            arrList.RemoveAt(2);
            foreach (string num in arrList)
            { 
                Console.WriteLine(num);
            }

            HashSet<A> hs = new HashSet<A>();
            hs.Add(new A { Id = 7, name = "Babken" });
            hs.Add(new A { Id = 8, name = "Arpi" });
            Console.WriteLine(hs.Count);
            foreach (A num in hs)
            {
                Console.WriteLine(num.Id+" "+num.name);
            }

            Hashtable hb = new Hashtable();
            hb.Add(10,"Al");
            hb.Add(11, "Bl");
            Console.WriteLine(hb.Count);
            ICollection st = hb.Values;
            foreach (string num in st)
            {
                Console.WriteLine(num);
            }

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Hakob" );
            d.Add(2, "Hako" );
            d.Add(3, "Hak" );
            d.Add(4, "Ha" );
            ICollection<string> s = d.Values;
            foreach (string num in s)
            {
                Console.WriteLine(num);
            }









        }
    }
}
