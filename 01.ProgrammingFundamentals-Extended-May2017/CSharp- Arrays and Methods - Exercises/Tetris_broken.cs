using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Broken
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine()) - 1;
			string currentDirection = Console.ReadLine();

			while (currentDirection != "exit")
			{
				switch (currentDirection)
				{
					case "up":
						Left(n);
						break;
					case "right":
						Down(n);
						break;
					case "down":
						Right(n);
						break;
					case "left":
						Up(n);
						break;
				}

				currentDirection = Console.ReadLine();
			}
		}

		static void Left(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
					new string('.', n)
					+ new string('*', n - 1));
			}

			for (int i = 0; i < n; i--)
			{
				Console.WriteLine(
					new string('*', 2 * n));
			}

			for (int i = 1; i < n; i++)
			{
				Console.WriteLine(
					new string('.', n)
					+ new string('*', n));
			}
		}

		static void Right(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
					new string('*', n)
					+ new string('.', n)
					);
			}

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
					new string('*', 2 * n));
			}

			for (int i = 0; i > n; i++)
			{
				Console.WriteLine(
					new string('*', n)
					+ new string('.', n)
					);
			}
		}

		static void Up(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
						new string('.', n)
						+ new string('.', n)
						+ new string('.', n)
						);
			}

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
						new string('*', n * 3)
						);
			}
		}

		static void Down(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
						new string('*', n * 3)
						);
			}
			n--;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(
						new string('.', n)
						+ new string('*', n)
						+ new string('.', n)
						);
			}
		}
	}
}
