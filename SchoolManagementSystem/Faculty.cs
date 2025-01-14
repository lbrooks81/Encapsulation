using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Faculty : Person
    {
        public int Id { get; set; }
        private List<Class>? Classes { get; set; }

        public Faculty(String fname, String lname, String gender, int age) 
            : base(fname, lname, gender, age)
        { }
    }
}
