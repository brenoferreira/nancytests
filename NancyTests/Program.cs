using System;
using Nancy.Hosting.Self;

namespace NancyTests
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var nancyHost = new NancyHost(new Uri("http://localhost:1234"));

			nancyHost.Start();

			Console.WriteLine("Listening at localhost:1234");

			Console.ReadKey();

			nancyHost.Stop();
        }
	}
}
