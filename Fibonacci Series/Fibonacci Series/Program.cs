using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
	public class Program
	{
		static void Main(string[] args)
		{
			int number;
			Console.WriteLine("Enter the number of fibonacci series");
			number = Convert.ToInt32(Console.ReadLine());
			FIB(number);
		}

		/// <summary>
		/// This is service method is calculate the fibonacci series 
		/// </summary>
		/// <param name="number">This is take int parameter</param>
		public static void FIB(int number)
		{
			int n1 = 0, n2 = 1, n3;
			for (int i = 1; i < number; i++)
			{
				if (i == 1)
				{
					Console.Write($"{n1} {n2} ");
				}

				else
				{
					n3 = n1 + n2;
					Console.Write($"{n3} ");
					n1 = n2;
					n2 = n3;
				}
			}
			Console.WriteLine();
		}
	}
}
