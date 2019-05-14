using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class PersonCompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age- y.Age > 0)
                return 1;
            if (x.Age == y.Age)
                return 0;
            else
                return -1;
        }
    }
}
