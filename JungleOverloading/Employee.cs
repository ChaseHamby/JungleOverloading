using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set;  }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        static List<string> restaurants = new List<string>
        {
            "City House",
            "Peter's Sushi",
            "Subculture",
            "Martin's BBQ"
        };

        public string randomRestaurant()
        {
            var Random = new Random();
            int r = Random.Next(restaurants.Count);
            return((string)restaurants[r]);
        }

        public void eat()
        {
            Console.WriteLine($"I saw {FirstName} {LastName} eating at {randomRestaurant()} yesterday!");
        }

        public void eat(string food)
        {
            Console.WriteLine($"I saw {FirstName} {LastName} eating {food} at {randomRestaurant()} yesterday!");
        }

        public void eat(List<Employee> companions)
        {
            //eat();
            foreach (var employee in companions)
            {
                Console.WriteLine($"I'm eating with {employee.FirstName} at {randomRestaurant()}!");
            }
        }

        public void eat(string food, List<Employee> companions)
        {
            Console.WriteLine($"I am eating {food}");
            eat(companions);
        }
    }
}
