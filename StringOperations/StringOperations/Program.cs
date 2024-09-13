using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace StringOperations
{
        internal class Program
        {
            static void Main(string[] args)
            {
                string str1 = "Hello";
                string str2 = "World!";
                string sentence = "C# is super fun!";
                string name = "John";
                int age = 22;

                Console.WriteLine(str1+" "+str2); //concatenate strings
                Console.WriteLine(sentence.Length); //print string length
                if (sentence.Contains("C#")) //find a substring in a string
                {
                    Console.WriteLine(true);
                }
                Console.WriteLine(sentence.Replace("fun", "powerfull")); //replace substring
                Console.WriteLine(string.Format("Name: {0}, Age: {1}", name, age)); //format string
                string[] words = sentence.Split(' '); // split string by " "
                foreach (string word in words) 
                { 
                    Console.WriteLine(word);
                }
                Console.WriteLine(sentence.ToLower()+" "+sentence.ToUpper()); //lower and upper case
            }
        }
}
