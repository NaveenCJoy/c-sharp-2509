using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class ConfigStatic
    {
        public static string ApplicationName;
        public static double ApplicationVersion;

        public string preference;

        static ConfigStatic()
        {            
            ApplicationName = "hello";
            ApplicationVersion = 2.0;

        }

        public ConfigStatic(string Preference)
        {
            preference = Preference;
        }

        public void DisplayConfirguration()
        {
            Console.WriteLine($"App Name: {ApplicationName}  App version: {ApplicationVersion}  " +
                $"User preference: {preference}");            
        }
    }
}
