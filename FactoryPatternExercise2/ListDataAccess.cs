using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Xbox", Price = 350},
            new Product(){Name = "PS5", Price = 450},
            new Product(){Name = "Switch", Price = 399},
            new Product(){Name = "Steam Deck", Price = 475}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Access Database");
        }
    }
}
