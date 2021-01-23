using System;
using System.Collections.Generic;

namespace odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> isimler = new Dictionary<int, string>();
            //isimler.Add(15, "mert");
            //isimler.Add(25, "zeynep");
            //Console.WriteLine(isimler.Count);


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(15, "sinan");
            myDictionary.Add(25, "mert");
            myDictionary.PrintAll();

        }
    }
}
