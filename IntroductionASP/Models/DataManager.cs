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

        static List<WatchTool> watchToolList = new List<WatchTool>
        {
            new WatchTool {Id = 1, Name = "Oiler", Description = "A nice oiler indeed.", Price = 10, InventoryCount = 2, Supplier = "Bosses Oilers", Weight = 25},
            new WatchTool {Id = 2, Name = "Screwdriver", Description = "A tasty drink.", Price = 40, InventoryCount = 0, Supplier = "Al's Liquor", Weight = 375}
        };
        internal static WatchToolsIndexVM[] GetAllWatchTools()
        {

            return watchToolList
                .OrderBy(t => t.Name)
                .Select(t => new WatchToolsIndexVM
                {
                    Name = t.Name,
                    Price = t.Price,
                    IsInStock = t.InventoryCount > 0

                })
                .ToArray();

            
        }
    }
}
