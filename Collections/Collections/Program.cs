using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add(3.14);
            foreach (var item in arrayList) // var when type can be vary
            {
                Console.Write(item+"; ");
            }

            // Stack (Non-generic)
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Pop(); // Pop() removes the last element
            Console.Write('\n'); // new line using \n or just use empty WriteLine
            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }

            // Queue (Non-generic)
            Queue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            Console.WriteLine("Queue dequeue: " + queue.Dequeue()); //Dequeue() returns the first element

            // Generic collection: List<>
            List<int> intList = new List<int> { 1, 2, 3, 4 };
            intList.Add(5);
            Console.WriteLine("List count: " + intList.Count); //count returns the number of elements in the list
            Console.WriteLine("First item in list: " + intList[0]); //get the first element

            // Convert List<> to array [1,2,3,4,5]
            int[] arrayFromList = intList.ToArray();
            Console.WriteLine("Array from List: " + string.Join(", ", arrayFromList)); //join elements by ", "

            // Convert array to List<>
            int[] newArray = { 6, 7, 8 };
            List<int> listFromArray = new List<int>(newArray);
            Console.WriteLine("List from array: " + string.Join(", ", listFromArray)); //join elements by ", "

            // Hashtable (non-generic)
            Hashtable hashtable = new Hashtable();
            List<int> evenNums = new List<int>();
            hashtable.Add("one", 1);
            hashtable.Add("two", 2);
            hashtable.Add("three", 3);
            hashtable.Add("four", 4);
            hashtable.Add("five", 5);
            hashtable.Add("six", 6);
            hashtable.Add("seven", 7);
            hashtable.Remove("three");
            foreach (DictionaryEntry entry in hashtable)
            {
                if ((int)entry.Value % 2 == 0) 
                {
                    evenNums.Add((int)entry.Value);
                }
            }
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNums));
        }
    }
}
