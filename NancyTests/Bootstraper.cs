using System;
using Nancy;
using Nancy.Diagnostics;

namespace NancyTests
{
    public class Bootstraper : DefaultNancyBootstrapper
    {
        public Bootstraper()
        {

        }

        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get { return new DiagnosticsConfiguration { Password = "123456"}; }
        }

    }
}

