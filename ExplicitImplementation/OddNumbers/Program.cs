using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Odd Numbers:");
            OddGenerator gen = new OddGenerator();

            foreach (var odd in gen)
            {
                if (odd > 50)
                    break;
                Console.WriteLine(odd);
            }

            Console.Read();
        }
    }
}
