using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_With_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \n print out the quotation mark.");

            string firstName = "Anele";
            string lastName = "Nontshokweni";
            //concatination
            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case sensitive
            Console.WriteLine(firstName[0]);
            //indexOf will tell u iff the value is there and at what position
            Console.WriteLine("index of a is ");
            Console.WriteLine(lastName.IndexOf('a'));//can use double quotes too
            //substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index and length ie how chars u wanna grab
            Console.WriteLine(firstName.Substring(1, 2));
            Console.Read();
        }
    }
}
