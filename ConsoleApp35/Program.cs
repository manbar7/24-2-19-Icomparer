using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] Persons = new Person[]
            {
               new Person (3,19,1.80f,"John"),
               new Person (2,21,1.56f,"Nora"),
               new Person (1,54,1.67f,"Dave"),
               new Person (5,43,1.85f,"Adam"),
               new Person (4,8,1.35f,"Paula")

            };

            PrintPersonArray(Persons);

            Array.Sort(Persons);
            PrintPersonArray(Persons);
            Array.Sort(Persons,new PersonCompareByName());
            PrintPersonArray(Persons);
            Array.Sort(Persons, new PersonCompareByHeight());
            PrintPersonArray(Persons);
            Array.Sort(Persons, new PersonCompareByAge());
            PrintPersonArray(Persons);


            SortAndPrint(Persons, new PersonCompareById());
            SortAndPrint(Persons, new PersonCompareByAge());
            SortAndPrint(Persons, new PersonCompareByHeight());
            SortAndPrint(Persons, new PersonCompareByName());

            SortAndPrint(Persons, Person.IDComparer);
            SortAndPrint(Persons, Person.AgeComparer);
            SortAndPrint(Persons, Person.HeightComparer);
            SortAndPrint(Persons, Person.NameComparer);
        }
        static void SortAndPrint(Person[] persons, IComparer<Person> theComparer)
        {
            Console.WriteLine("==================");
            Console.WriteLine($"== Sort by {theComparer.GetType()}");
            Console.WriteLine("==================");
            Array.Sort(persons, theComparer);
            PrintPersonArray(persons);
        }

        static void PrintPersonArray(Person[] persons)
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("=============================");
        }
    }
}
