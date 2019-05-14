using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }


        private static readonly IComparer<Person> _compareById;
        private static readonly IComparer<Person> _compareByAge;
        private static readonly IComparer<Person> _compareByHeight;
        private static readonly IComparer<Person> _compareByName;

        public static IComparer<Person> IDComparer
        {
            get
            {
                return _compareById;
            }
        }

        public static IComparer<Person> AgeComparer
        {
            get
            {
                return _compareByAge;
            }
        }
        public static IComparer<Person> HeightComparer
        {
            get
            {
                return _compareByHeight;
            }
        }
        public static IComparer<Person> NameComparer
        {
            get
            {
                return _compareByName;
            }
        }

        private static IComparer<Person> DefaultComparer;



        static Person()
        {
            _compareById = new PersonCompareById();
            _compareByHeight = new PersonCompareByHeight();
            _compareByAge = new PersonCompareByAge();
            _compareByName = new PersonCompareByName();
        }

        public Person(int id, int age, float height, string name)
        {
            this.Id = id;
            this.Age = age;
            this.Height = height;
            this.Name = name;
        }

        

        public int CompareTo(Person person)
        {
            //return this.Id - person.Id;
            if (this.Id - person.Id > 0)
                return 1;
            if (this.Id == person.Id)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return $"Name {Name} Id {Id}  Age {Age} Height {Height}";

        }
    }
}
