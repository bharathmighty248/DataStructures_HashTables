using System;

namespace DataStructures_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
            string hash2 = hash.Get("2");
            Console.WriteLine("1st index value: " + hash2);
            string hash13 = hash.Get("13");
            Console.WriteLine("13th index value: " + hash13);
            string hash15 = hash.Get("15");
            Console.WriteLine("15th index value: " + hash15);
        }
    }
}
