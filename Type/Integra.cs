using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    class Integra : SolutionProvider
    {
        public override void Partner(ServiceProvider s)
        {
            // service partner
            Console.WriteLine(this.GetType().Name + " partner with " + s.GetType().Name);
        }
    }
}