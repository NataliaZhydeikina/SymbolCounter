using System;

namespace SymbolCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteResult(SymbolCount(ReadString()));
        }

        static string ReadString()
        {
            Console.WriteLine("Please enter string:");
            return Console.ReadLine();
        }

        static int SymbolCount(string str)
        {
            str = str.Replace(" ", "");
            return str.Length;
        }
        
        static void WriteResult(int count)
        {
            Console.WriteLine($"String contains {count} symbols");
        }
    }
}
