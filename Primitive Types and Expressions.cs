using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{
    internal class Primitive_Types_And_Expressions
    {
        public static void doApp()
        {
            bool Bool = true;
            byte Byte = 189;
            char Char = 'G';
            double Double = 388.33;
            float Float = 334.3f;
            int num = 83;
            long lNum = 3738178;
            Object obj = new Object();
            short Short = 23;
            string name = "Praveen";

            if (Bool && Byte < 300)
                Console.WriteLine("This Expression Evaluates to True");
            if (Short > 6 || num < 0)
                Console.WriteLine("This Expression Evaluates to False");
        }
        static void Main(string[] args)
        {
            doApp();

            Console.ReadKey();
        }

    }
}