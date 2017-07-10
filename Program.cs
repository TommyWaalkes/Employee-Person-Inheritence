using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{


    class TestClass
    {
        static void Main()
        {

            //Console.WriteLine("PERSON OBJECT OUTPUT");
            //Person p = new Person();
            //p.GetInfo();
            //Console.WriteLine();
            //Console.WriteLine("EMPLOYEE OBJECT OUTPUT");
            //Employee e = new Employee();
            // e.GetInfo();
            //e.PrintName();

           // Polymorphism in action
            Employee e = new Employee();
            e.GetInfo();
            List<Person> people = new List<Person>();
            people.Add(new Employee());
            Person c = people[0];
            c.GetInfo();

        }
    }
}
