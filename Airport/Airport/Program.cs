namespace Airport {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Passenger passenger = new Passenger();

            Menu();
            string command = Console.ReadLine().ToUpper();
            while (command != "Q") {
                switch (command) {
                    case "PN":
                        passenger.NewPassenger();
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

        public static void Menu() {
            Console.WriteLine("The following commands are available:\n" +
                "PN - New passenger\n" +
                "B - Test\n" +
                "Q - Quit\n");
        

        }




    }
}