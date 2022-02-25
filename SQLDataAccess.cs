using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
             new Product (){Name = "Xbox", Price = 350},
             new Product() { Name = "DVD Player", Price = 100},
             new Product() { Name = "VCR", Price = 25},
             new Product() { Name = "TV", Price = 500},
         };
        public List<Product> LoadData()
        {
           Console.WriteLine("I am reading data from SQL data access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL of data access ");
        }
    }



}
        
    

