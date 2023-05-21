using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>

    class MobileAppFactory : SoftwareFactory
    {
        public override SolutionProvider CreateSolutionProvider()
        {
            return new ESOIBO();
        }

        public override ServiceProvider CreateServiceProvider()
        {
            return new MIT();
        }
    }
}
