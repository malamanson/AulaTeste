using System;
using System.Collections.Generic;

namespace Aula77
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Ana");
            list.Add("José");
            list.Insert(2, "Arco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho Lista: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Fisrt A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Firt Position: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("---------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
                Console.WriteLine("Mala Git");
            }
        }
    }
}
