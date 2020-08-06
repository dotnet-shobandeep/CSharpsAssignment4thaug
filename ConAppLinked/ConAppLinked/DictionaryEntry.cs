using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLinked
{
    class DictionaryEntry
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One"); //DictionaryEntry
            ht.Add("two", 15.67);
            ht.Add('c', "Caochin");
            ht.Add(12, "Twelve");

            //foreach(var item in ht)
            //{
            //    Console.WriteLine(item);

            //}

            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("{0}={1}", de.Key, de.Value);
            }
            IDictionaryEnumerator ide = ht.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine("{0} :{1}", ide.Key, ide.Value);
            }

            //Contains, cotainsKey, ContainsValue,CopyTo,Keys and Values property

            if (ht.ContainsKey("Twelve"))
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Fuck off");
            }


            if (ht.ContainsKey('c'))
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Fuck off");
            }

            if (ht.ContainsValue('c'))
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Fuck off");
            }

            Array arrObj = new Object[ht.Count];
            ht.CopyTo(arrObj, 0);
            Console.WriteLine("Values after copying ht data into arrObj");
            //foreach (var item in arrObj)
            //{
            //    Console.WriteLine(item.Keys +);
            //}
            Console.WriteLine("-----------Keys--------");
            ICollection allKeys = ht.Keys;
            foreach (var v in allKeys)
            {
                Console.WriteLine(v);
            }


            Console.WriteLine("-----------Values--------");
            ICollection allVals = ht.Values;
            foreach (var p in allVals)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("----------Sorted List---------");

            SortedList slt = new SortedList();
            slt.Add("one", "first");
            slt.Add("two", "second");
            slt.Add("three", "third");
            slt.Add("four", "fourth");
            slt.Add("five", "fifth");

            foreach (DictionaryEntry q in slt)
            {
                Console.WriteLine(q.Key + ":" + q.Value);
            }
            Console.Read();

            IList il = slt.GetValueList();
            Console.WriteLine("--------");
            foreach (var item in il)
            {
                Console.WriteLine(item);
            }
        }
    }
}
