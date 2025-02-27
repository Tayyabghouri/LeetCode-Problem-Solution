using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Person
    {
        public int groupBy { get; set; }
        public string Name { get; set; }

        public Person(int groupBy, string name)
        {
            this.groupBy = groupBy;
            this.Name = name;
        }

    }
}
