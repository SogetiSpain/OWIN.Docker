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
            string address = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: address))
            {
                Console.ReadKey();
            }
        }
    }
}
