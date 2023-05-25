using System.Data.SqlClient;

namespace Airport {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Passenger passenger = new Passenger(123, "Foo", "Bar", 10, "Norway");
            Console.WriteLine(passenger.FirstName +  " " + passenger.LastName);

            try {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";       // update me
                builder.UserID = "sa";                  // update me
                builder.Password = "your_password";     // update me
                builder.InitialCatalog = "master";

                // Connect to SQL
                Console.Write("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString)) {
                    connection.Open();
                    Console.WriteLine("Done.");
                }
            }
            catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
        





            Menu();

        }

        /// <summary>
        /// 
        /// </summary>
        public static void Menu() {
            MenuOptions();
            string command = Console.ReadLine().ToUpper();
            while (command != "Q") {
                switch (command) {
                    case "A":
                        Console.WriteLine("test1");
                        break;
                    case "B":
                        Console.WriteLine("test2");
                        break;
                    default:
                        Menu();
                        break;

                }
                command = Console.ReadLine().ToUpper();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void MenuOptions() {
            Console.WriteLine("The following commands are available:\n" +
                "A - test\n" +
                "B - Test\n" +
                "Q - Quit\n");
        

        }




    }
}