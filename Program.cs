using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Step 3
//This also can help in configuring log4net inside the Code itself
[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace Log4NetTest
{
    class Program
    {
        //Step 4
        // You need to define new GetLogger names when u define in diff class or use reflection but avoid in resource intensive programmes
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Console.WriteLine("Helllo logging");
            log.Error("This is my error message");
            Console.ReadLine();
        }
    }
}
