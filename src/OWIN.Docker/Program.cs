namespace Owin.Docker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Owin.Hosting;

    class Program
    {
        static void Main(string[] args)
        {

#if LINUX
            string address = "http://*:9000/";
#else
            string address = "http://localhost:9000/";
#endif

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: address))
            {
                Console.ReadKey();
            }
        }
    }
}
