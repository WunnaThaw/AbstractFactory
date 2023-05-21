using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>

    abstract class SoftwareFactory
    {
        public abstract SolutionProvider CreateSolutionProvider();

        public abstract ServiceProvider CreateServiceProvider();
    }
}
