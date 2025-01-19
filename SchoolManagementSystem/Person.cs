using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Person
    {
        public String FName { get; set; }
        public String LName { get; set; }
        public String Gender { get; set; }
        public int Age { get; set; }

        public Person(String fname, String lname, String gender, int age)
        {
            FName = fname;
            LName = lname;
            Gender = gender;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{LName}, {FName} | Age: {Age} | Gender: {Gender}");
        }
    }
}
