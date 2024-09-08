namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("Toyota", "Camry"); // create new car
            Console.WriteLine("{0}, {1} - Engine ID: {2}", toyota.Brand, toyota.Model, toyota.GetEngineId()); // format string
            toyota.Rev(); // call Rev() method
            toyota.Rev();
            toyota.Rev();
            toyota.Rev();

            Car ferrari = new SportsCar("Ferrari", "488", 700); // create new sports car
            Console.WriteLine("{0}, {1} - HP: {2} - Engine ID: {3}", ferrari.Brand, ferrari.Model, ferrari.hp, ferrari.GetEngineId()); // format string
            ferrari.Rev(); // call the overridden Rev() method
        }
    }
}
