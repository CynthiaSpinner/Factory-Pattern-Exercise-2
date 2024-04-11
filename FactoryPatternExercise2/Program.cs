namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do {

                correctInput = true;

                Console.WriteLine("What database do your want to use? List, SQL or Mongo");

                userInput = Console.ReadLine();

                if(userInput != "mongo" && userInput != "sql" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Try Again!");
                    Thread.Sleep(1000);
                }

            } while (!correctInput); ;

            Console.Clear();

            IDataAccess data = DataAccessFactory.GetDataAccessType(userInput);

            var products = data.LoadData();

            data.SaveData();

            foreach(var product in products) 
            {
                Console.WriteLine($"Product: {product.Name} Price: {product.Price}");
            }
        }
    }
}
