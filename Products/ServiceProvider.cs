using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>

    abstract class ServiceProvider
    {
        public abstract void Partner(SolutionProvider s);
    }
}
