using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppOwinDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>("http://localhost:5000"))
            {
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }

        }
    }
}
