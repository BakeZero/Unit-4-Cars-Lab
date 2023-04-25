namespace Unit_4_Cars_Lab
{
    internal class Program
    {
        static void Main()
        {
            Car.AddCar(new Car("Nikolai", "Model S", 2017, 54999.90m));
            Car.AddCar(new Car("Fourd", "Escapade", 2017, 31999.90m));
            Car.AddCar(new Car("Chewie", "Vette", 207, 44989.95m));
            Car.AddCar(new UsedCar("Hyonda", "Prior", 2015, 14795.50m, 35987.6));
            Car.AddCar(new UsedCar("GC", "Chirpus", 2013, 8500.00m, 12345.0));
            Car.AddCar(new UsedCar("GC", "Witherell", 2016, 14450.00m, 3500.3));
            Car.ListCars();

            do
            {
                if (Car.GetSize() == 0)
                {
                    Console.WriteLine("Sorry, we're out of cars!");
                    break;
                }
                // 1-based indexing
                int index = Validator.GetNumber("Which car would you like? ", 1, Car.GetSize());
                Car.ListCar(index - 1);
                Console.WriteLine("Excellent! Our finance department will be in touch shortly.\n");
                Car.ListCars();
            } while (Continue());
            Console.WriteLine("Have a great day!");
        }

        static bool Continue()
        {
            Console.Write("Would you like another car? (y/n): ");
            string prompt = Console.ReadLine();

            if (prompt == "y")
                return true;
            else if (prompt == "n")
                return false;
            else
                return Continue();
        }
    }
}