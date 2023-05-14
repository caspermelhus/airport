namespace Airport {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Passenger passenger = new Passenger(123, "Foo", "Bar", 10, "Norway");
            Console.WriteLine(passenger.FirstName +  " " + passenger.LastName);

            Menu();
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

        public static void Menu() {
            Console.WriteLine("The following commands are available:\n" +
                "A - test\n" +
                "B - Test\n" +
                "Q - Quit\n");
        

        }




    }
}