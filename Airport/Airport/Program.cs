namespace Airport {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Passenger passenger = new Passenger(123, "Foo", "Bar", 10, "Norway");
            Console.WriteLine(passenger.FirstName +  " " + passenger.LastName);


        }
    }
}