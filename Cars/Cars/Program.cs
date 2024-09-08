namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("Toyota", "Camry"); // create new car
            Console.WriteLine("{0}, {1} - Engine ID: {2}", toyota.Brand, toyota.Model, toyota.GetEngineId()); // format string
            toyota.Rev(); // call Rev() method
            
        }
    }
}
