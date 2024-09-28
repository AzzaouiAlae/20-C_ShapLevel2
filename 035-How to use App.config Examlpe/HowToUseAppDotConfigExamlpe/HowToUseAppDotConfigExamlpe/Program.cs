using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HowToUseAppDotConfigExamlpe
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            string LogLevel = ConfigurationManager.AppSettings["LogLevel"];
            string Alae = ConfigurationManager.AppSettings["Alae"];

            string MyDbConnection = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            Console.WriteLine("\nConnectionString = " + ConnectionString);
            Console.WriteLine("\nlogLevel = " + LogLevel);
            Console.ReadKey();
        }
    }
}
