namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool correctInput;
            do 
            {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Which database will you be using?");
                Console.WriteLine("Your options are Mongo, SQL, and List.");
                userInput = Console.ReadLine().ToLower();

                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input! Your options are mongo, sql, list. Try again...");
                    Thread.Sleep(3000);
                }
            } 
            while (!correctInput);

            Console.Clear() ;
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();
            
            foreach (var item in products)
            {
                Console.WriteLine($"Name: {item.Name} --- Price: ${item.Price}");
            }
        }
    }
}
