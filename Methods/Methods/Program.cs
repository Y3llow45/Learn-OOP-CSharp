namespace Methods
{
    public class MyMethods
    {
        public static void ShowWelcomeMessage() // Static method with no parameters and no return value
        {
            Console.WriteLine("Welcome to my console app!");
        }
        public static int Add(int a, int b) // Static method with parameters and a return value
        {
            return a + b;
        }
        public static int AddMultiple(params int[] numbers) // Static method with variable number of arguments
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public void IncrementByRef(ref int number) // Instance method that modifies a parameter by reference
        {
            number++;
            Console.WriteLine("After incrementing by ref: " + number);
        }
        public void Divide(int dividend, int divisor, out int quotient, out int remainder) // Instance method that uses output parameters
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
        public static int Subtract(int a, int b = 1) // Static method with optional parameters
        {
            return a - b;
        }
        public int Multiply(int a, int b) // Overloaded method (different parameters, same method name)
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }   
        public void ShowCurrentTime() // Non-static method without returning value
        {
            Console.WriteLine("Current time is: " + DateTime.Now);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call static method without parameters
            MyMethods.ShowWelcomeMessage();

            // Call static method with parameters and return value
            int sum = MyMethods.Add(5, 10);
            Console.WriteLine("Sum of 5 and 10: " + sum);

            // Call static method with variable number of arguments
            int sumMultiple = MyMethods.AddMultiple(1, 2, 3, 4, 5);
            Console.WriteLine("Sum of multiple numbers: " + sumMultiple);

            // Call static method with optional parameters
            int difference1 = MyMethods.Subtract(10);
            int difference2 = MyMethods.Subtract(10, 5);
            Console.WriteLine("Difference with default argument: " + difference1);
            Console.WriteLine("Difference with passed argument: " + difference2);

            // Create an instance of the Calculator class
            MyMethods calc = new MyMethods();

            // Call non-static method
            calc.ShowCurrentTime();

            // Call method with reference parameter
            int number = 5;
            Console.WriteLine("Original number: " + number);
            calc.IncrementByRef(ref number);

            // Call method with output parameters
            int quotient, remainder;
            calc.Divide(10, 3, out quotient, out remainder);
            Console.WriteLine("Quotient: " + quotient + ", Remainder: " + remainder);

            // Call overloaded method
            int product1 = calc.Multiply(2, 3);
            int product2 = calc.Multiply(2, 3, 4);
            Console.WriteLine("Product of 2 and 3: " + product1);
            Console.WriteLine("Product of 2, 3 and 4: " + product2);
        }
    }
}
