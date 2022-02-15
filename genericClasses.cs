/*
Generic Classes

The class Elems creates a 3-sized array of integers, defines Add() and Show() methods to store the elements into the array, and shows them separated by a space.
Modify the class to make it generic to execute the same actions with string type, given in the Main function.
You need to replace the int type by the generic <T> type.
Each output should end with a space (including the last one).
*/

using System;
using System.Collections.Generic;

    class genericClasses
    {
        static void Main(string[] args)
        {

            Elems<string> elems1 = new Elems<string>();
            elems1.Add("John", "Tamara", "David");
            elems1.Show();

            Console.WriteLine();

            Elems<int> elems2 = new Elems<int>();
            elems2.Add(5, 14, 13);
            elems2.Show();

        }
    }
    //make this class generic
    class Elems <T>
    {
        public T[] elements = new T[3];

        public void Add(T elem1, T elem2, T elem3)
        {
            elements[0] = elem1;
            elements[1] = elem2;
            elements[2] = elem3;
        }

        public void Show()
        {
            foreach (T item in elements)
            {
                Console.Write(item + " ");
            }
        }
    }
