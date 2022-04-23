using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_26
{
    internal class Dict_Hash
    {
        /// <summary>
        /// 1. Retrieve all the Keys and Values using Dictionary and Hashtable.
        /// </summary>
        public static void Main()
        {
            Dictionary1();
            HashTable1();
        }
        public static void Dictionary1()
        {
            Console.WriteLine("1. Retrieve all the Keys and Values using Dictionary and Hashtable.");
            //generic collection
            //defines under System.Collections.Generic namespace
            //Specify the type of the key and value
            //Key value pairs of same type
            Console.WriteLine("\n***Dictionary***\n");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            //Always maintain the order of stored values
            dict.Add("India","New Delhi");
            dict.Add("United States","Washington D.C");
            dict.Add("United Kingdom","London");
            dict.Add("Japan","Tokyo");
            dict.Add("China", "Beijing");
            dict.Add("Oman", "Muscat");
            Console.WriteLine("Keys in the Dictionary");
            var country = new List<string>(dict.Keys);
            foreach (var key in country)
            {
                Console.WriteLine("Keys are:{0} ", key);
            }
            Console.WriteLine("Values in the Dictionary");
            var capital = new List<string>(dict.Values);
            foreach (var value in capital)
            {
                Console.WriteLine("Values are:{0} ", value);
            }

        }
        public static void HashTable1()
        {
            //non generic collection
            //it defines under System.Collections namespace
            //No need to specify the type of the key and value
            Hashtable hashtable = new Hashtable();
            //Key value pair of same type or different type
            //it doesn't maintain the order of stored values
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");
            hashtable.Add(4, "Four");
            hashtable.Add("Five", "Five");
            hashtable.Add(6, "Six");
            Console.WriteLine("\n***Hashtable***\n");
            ICollection collection = hashtable.Keys;
            foreach (var key in collection)
            {
                Console.WriteLine("Keys Are:{0}", hashtable[key]);
            }
            //It will give null value if you try to access a key that doesn't present in hashtable
            Console.WriteLine("Non-key value:{0}", hashtable[5]);
        }
    }
}
