using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run the Web IT
            SoftwareFactory web = new WebFactory();
            IT it = new IT(web);
            it.GetSolutionProviderPartner();
            it.GetServiceProviderPartner();

            // Create and run the Mobile App IT
            SoftwareFactory mobileapp = new MobileAppFactory();
            it = new IT(mobileapp);
            it.GetSolutionProviderPartner();
            it.GetServiceProviderPartner();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
