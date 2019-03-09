using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();

        static void Main(string[] args)
        {
            var chase = new Employee("Chase", "Hamby");
            var wayne = new Employee("Wayne", "Collier");
            var leo = new Employee("Leo", "Hamby");

            Employees.Add(chase);
            Employees.Add(wayne);
            Employees.Add(leo);

            chase.eat();
            chase.eat("burgers");
            chase.eat(Employees);
            chase.eat("burgers", Employees);


            Console.ReadKey();
        }
    }
}
