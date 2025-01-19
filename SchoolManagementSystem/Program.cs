/*
 * Name: Logan Brooks
 * South Hills Username: lbrooks81
 */

namespace SchoolManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            Class c1 = new Class("Software Engineering", "IT231", null);
            Class c2 = new Class("Job Search Skills", "CD207", null);
            Class c3 = new Class("Project Management", "CP 277", null);
            
            Faculty nick = new Faculty("Nicholas", "Page", "Male", 28);
            Faculty ray = new Faculty("Ray", "Liddick", "Male", 50);
            Faculty mike = new Faculty("Michael", "Gates", "Male", 60);
            
            Student logan = new Student("Logan", "Brooks", "Male", 21);
            Student kaci = new Student("Kaci", "Craycraft", "Female", 28);
            Student rachel = new Student("Rachel", "Henninger", "Female", 28);
            Student kevin = new Student("Kevin", "Todd", "Male", 35);
            Student ian = new Student("Ian", "Paulhamus", "Male", 20);
            Student michaela = new Student("Michaela", "Sallese", "Female", 28);
            List<Student> students = [logan, kaci, rachel, kevin, ian, michaela];

            c1.EnrollStudents([logan, kaci, rachel, ian, michaela]);
            c2.EnrollStudents([logan, kaci, rachel, kevin, ian, michaela]);
            c3.EnrollStudents([logan, kaci, rachel, kevin, ian, michaela]);

            c1.AssignTeacher(nick);
            c2.AssignTeacher(mike);
            c3.AssignTeacher(ray);

            c1.DisplayInfo();
            c2.DisplayInfo();
            c3.DisplayInfo();

            foreach(Student s in students)
            {
                Console.WriteLine($"\n{s.FName}'s Classes");
                s.DisplayClasses();
            }
        }
    }
}
