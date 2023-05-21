using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>

    class IT
    {
        private ServiceProvider _serviceProvider;
        private SolutionProvider _solutionProvider;

        // Constructor
        public IT(SoftwareFactory factory)
        {
            _solutionProvider = factory.CreateSolutionProvider();
            _serviceProvider = factory.CreateServiceProvider();
        }

        public void GetSolutionProviderPartner()
        {
            _solutionProvider.Partner(_serviceProvider);
        }

        public void GetServiceProviderPartner()
        {
            _serviceProvider.Partner(_solutionProvider);
        }
    }
}
