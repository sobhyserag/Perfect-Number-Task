using System;
using System.Linq;

namespace Perfect_Number
{
	public static class Program
	{
		public static void Main()
		{
          Console.WriteLine("A program that prints perfect numbers between two numbers");
          
          Console.WriteLine("Please Enter The First Number");
          int number1 = int.Parse(Console.ReadLine());
          
          Console.WriteLine("Please Enter The Second Number");
          int number2 = int.Parse(Console.ReadLine());
          
          for(;number1<=number2;number1++)
          {
          	int sum = 0;
          	
          	for(int i = 1;i<number1;i++)
          	{
          		if(number1 % i ==0)
          		{
          			sum+=i;
          		}
          		
          	}
          	
          	if(sum==number1)
          	{
          		Console.WriteLine("  " + number1 +"  : is perfect number");
          	}
          }
		}
	}
}