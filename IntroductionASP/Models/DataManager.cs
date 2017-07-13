using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionASP.Models
{
    public class DataManager
    {
        static List<Customer> customerList = new List<Customer>
        {
            new Customer {CompanyName = "Acme", EmployeeCount = 300},
            new Customer {CompanyName = "Warn Kitten", EmployeeCount = 1},
            new Customer {CompanyName = "Academy", EmployeeCount = 5},
            new Customer {CompanyName = "Academic Work", EmployeeCount = 9999 }

        };

        public static Customer[] GetAllCustomers()
        {
            return customerList
                .ToArray();
        }

        static List<Unicorn> unicornList = new List<Unicorn>
        {
            new Unicorn {Name = "Sparklez", SparkleLevel = 502, Colour = "Magenta"},
            new Unicorn {Name = "Glitterz", SparkleLevel = 238, Colour = "Babyblue"},
            new Unicorn {Name = "Shinzeyz", SparkleLevel = 105, Colour = "Peach"}
        };

        public static Unicorn[] GetAllThemUnicorns()
        {
            return unicornList
                .ToArray();
        }
    }
}
