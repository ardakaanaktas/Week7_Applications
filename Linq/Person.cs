using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Person : IComparable<Person>
    {
        public long id { get; set; }
        public int age { get; set; }
        public string name { get; set; }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1; // Null kontrolü ekleyelim

            if (id > other.id)
                return 1;
            else if (id < other.id)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
