using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class genericMethods
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());
            Printer.Print(ref text);
            Printer.Print(ref intNum);
            Printer.Print(ref doubNum);
        }
    }
    class Printer
    {   
        public static void Print<T>(ref T x){
            Console.WriteLine(x);
        }
    }
