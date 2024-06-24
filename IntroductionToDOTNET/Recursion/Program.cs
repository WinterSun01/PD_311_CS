﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	class Program
	{
		static void Main(string[] args) //Caller - вызывающая функция
		{
			//Function();
			//Stack overflow exception
			//Stack (Стопка) - это модель памяти, 
			//из которой последний записанный элемент считывается первым.
			//Main(args);

			//Console.Write("Введите номер этажа: ");
			//int floor = Convert.ToInt32(Console.ReadLine());
			//Elevator(floor);

			//Console.Write("Введите число: ");
			//int n = Convert.ToInt32(Console.ReadLine());
			//try
			//{
			//	Console.WriteLine($"\n-----------------------\n{n}! = {Factorial(n)}");
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine($"{ex.GetType()}: {ex.Message}");
			//}

			Console.Write("Введите основание степени: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите показатель степени: ");
			int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(a, n));
			Main(args);

        }
		static void Function()  //Callee - вызываемая функция
		{
			Console.WriteLine("Привет!");
			Console.WriteLine("Я функция ))");
		}
		static void Elevator(int floor)
		{
			if (floor == 0)
			{
				Console.WriteLine("Вы в подвале");
				return;
			}
			Console.WriteLine($"Вы на {floor} этаже");
			Elevator(floor - 1);
			Console.WriteLine($"Вы на {floor} этаже");
		}
		static long Factorial(long n)
		{
			if (n == 0) return 1;
			long f = n * Factorial(n - 1);
			Console.WriteLine($"{n}! = {f}");
			return f;
		}
		static double Power(double a, int n)
		{
			return n == 0 ? 1 : n > 0 ? a * Power(a, n - 1) : 1/Power(a, -n);
			//if (n == 0) return 1;
			//else if (n > 0) return a * Power(a, n - 1);
			//else return 1 / Power(a, -n);
		}
	}
}
