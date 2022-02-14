/*
Exception Handling


A tour operator offers package holidays in England, Spain, Italy, Portugal and France.
The program you are given defines an array with those options and takes N number as input.
Write a program to output the package option with N index. If the number is out of range, program should output "Wrong number". Regardless of the option results, the program should output "Goodbye" at the end.

Sample Input
2

Sample Output
Italy
Goodbye
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class exceptionHandling{
    static void Main(string[] args){
        string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
        int choice = Convert.ToInt32(Console.ReadLine());
                  
        try
        {
            switch (choice){
                case 0:
                    Console.WriteLine(tours[choice]);
                    break;
                case 1:
                    Console.WriteLine(tours[choice]);
                    break;   
                case 2:
                    Console.WriteLine(tours[choice]);
                    break;  
                case 3:
                    Console.WriteLine(tours[choice]);
                    break;   
                case 4:
                    Console.WriteLine(tours[choice]);
                    break;   
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }                
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }
    }
}
