using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class ACE : ServiceProvider
    {
        public override void Partner(SolutionProvider s)
        {
            // product partner
            Console.WriteLine(this.GetType().Name + " partner with " + s.GetType().Name);
        }
    }
}