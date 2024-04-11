using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Labtop", Price = 3000},
                new Product() { Name = "TV", Price = 900},
                    new Product() { Name = "Surround Sound", Price = 1000},
                        new Product() { Name = "Studio Monitors", Price = 2000}
        };
            
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from SQL Data Access");

            return Products;
            
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from SQL Data Access ");
        }
    }
}
