using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>

    abstract class SolutionProvider
    {
        public abstract void Partner(ServiceProvider s);
    }
}
