using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateData
{
    class ConcatenateData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your town");
            var town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2} - years old person from {3}.", firstName, lastName, age, town);
            // Console.WriteLine($"You are {firstName} {lastName}, a {age} - years old person from {town}.");
        }
    }
