using System;

namespace ConsoleWorks.Console.View;

public static class Display
{
	public static void Hello()
	{
		System.Console.WriteLine("Hello");
	}
	public static void Hello(string name)
	{
		System.Console.WriteLine("Hello {0}", name);
	}
}
