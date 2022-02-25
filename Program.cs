using System;
using System.Threading;

namespace FactoryExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What database would you like to use?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: Mongo");
                Console.WriteLine("Type: List");

                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput != "mongo" && userInput != "List")
                {
                    correctInput = false;
                    Console.WriteLine("Input not correct");
                    Thread.Sleep(10000);
                }

            } while (!correctInput);

            Console.Clear();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name.{product.Name} Price:{product.Price}");
            }




        }
    }
}
