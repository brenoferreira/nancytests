using System;
using Nancy;

namespace NancyTests
{
	public class HelloWorldModule : NancyModule
	{
		public HelloWorldModule ()
		{
			Get["/hello"] = _ => "Hello World";
		}
	}
}

