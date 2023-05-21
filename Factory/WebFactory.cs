using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>

    class WebFactory : SoftwareFactory
    {
        public override SolutionProvider CreateSolutionProvider()
        {
            return new Integra();
        }

        public override ServiceProvider CreateServiceProvider()
        {
            return new ACE();
        }
    }
}
