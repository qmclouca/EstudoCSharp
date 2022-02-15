/*
Stack

The program you are given defines the evenNums stack and pushes 3 even numbers (6, 8 and 4) onto it.
The 4th number is taken from the user and also pushed. But we need to check whether it is also an even number.
Complete the program to perform that check process, and if the last pushed number N isn't even, remove it from stack and output "N: Removed" (see sample output).
At the end, output all the elements of the stack, separated by spaces.
Sample Input
1
Sample Output
Checking the last number: 1
1: Removed
6 8 4
Pop() - Returns the element at the top of the stack and removes it.
The output should end with a space.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class stackPractice{
	static void Main(string[] args)
		{
			Stack<int> evenNums = new Stack<int>();

			evenNums.Push(4);
			evenNums.Push(8);
			evenNums.Push(6);

			int num = Convert.ToInt32(Console.ReadLine());

			evenNums.Push(num);

			Console.WriteLine("Checking the last number: " + num);
			
			// your code goes here
			if (evenNums.Peek() % 2 != 0){
				Console.WriteLine(evenNums.Pop() +": Removed");
			}
			foreach (int element in evenNums){
				Console.WriteLine(element + " ");
			}
		}
}
