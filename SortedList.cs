/*
SortedList


There are 5 students in a class, and each needs to score at least 70 points to pass the exam.
The program you are given defines the sorted list and stores the names of the students as keys and the corresponding scores as values.
Complete the program to show the results of the exam.

Explanation
For example, if Tom passed the exam, the program should output "Tom: Passed", and if he didn't, "Tom: Failed".
The result of each student should be output on a new lane.
Use the Keys property which gets a sorted and indexed collection containing only the keys in the sorted list.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	class SortedList
	{
		static void Main(string[] args)
		{
			SortedList<string, int> exam = new SortedList<string, int>();

			exam.Add("Tom", 59);
			exam.Add("Robert", 95);
			exam.Add("Sophie", 72);
			exam.Add("Maria", 68);
			exam.Add("Nick", 84);

			foreach (string s in exam.Keys){
				if (exam[s] >=70){
					Console.WriteLine(s + ": Passed");
				} else {
					Console.WriteLine(s + ": Failed");
				}				
			}
		}
	}
