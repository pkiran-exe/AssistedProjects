using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{
    internal class ControlFlow
    {
        public static void doApp()
        {
            int age = 10;
            Console.WriteLine("Using If else");
            if (age > 18)
            {
                if (age < 60)
                    Console.WriteLine("Adult");
                else
                    Console.WriteLine("Elder");
            }
            else
                Console.WriteLine("Minor");
            Console.WriteLine("\nUsing While");
            while (age < 30)
                Console.Write(age++ + " ");
            Console.WriteLine();
            Console.WriteLine("\nUsing Do while");
            do
            {
                Console.Write(age++ + " ");
            } while (age < 60);
        }
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
    }
}