using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            var group = new Group()
            {
                Name = "P331",
            };
            AddGroup(groups, group);

            var group2 = new Group()
            {
                Name = "T202",
            };
            AddGroup(groups, group2);

            var group3 = new Group()
            {
                Name = "P202",
            };
            AddGroup(groups, group3);

            var group4 = new Group()
            {
                Name = "P331"                  //Same Group name is here!
            };
            AddGroup(groups, group4);

            foreach (var listGroup in groups)
            {
                Console.WriteLine(listGroup.GetDetails());
            }


            List<Student> students = new List<Student>();
            var student = new Student()
            {
                Name = "Alex",
                Surname = "Jackson",
                PIN = 51478
            };
            AddStudent(students, student);

            var student2 = new Student()
            {
                Name = "Johnny",
                Surname = "Miller",
                PIN = 78946
            };
            AddStudent(students, student2);

            var student3 = new Student()
            {
                Name = "Michael",
                Surname = "Johnson",
                PIN = 51478                       // Same PIN number is here
            };
            AddStudent(students, student3);

            foreach (var listStudent in students)
            {
                Console.WriteLine(listStudent.StudendtDetails());
            }

            NamesThatContainA(students);
        }
        static void AddGroup(List<Group> groups, Group group)  //  Task  1.2     Group Names are checked here!!!
        {

            var isOnList = groups.Any(l => l.Name == group.Name);

            if (!isOnList)
            {
                groups.Add(group);
            }

        }

        static void AddStudent(List<Student> students, Student student)  //  Task 2.2   Student PINs are checked here!!!
        {
            var isPinSame = students.Any(s => s.PIN == student.PIN);

            if (!isPinSame)
            {
                students.Add(student);
            }
        }

        static void NamesThatContainA(List<Student> students)  // Task 2.3  Count of Students with letter A or a in it
        {
            int count = students.Count(s => s.Name.Contains('a') || s.Name.Contains('A'));
            Console.WriteLine($"////////////////////////////////////////////////\nCount of students with letter [A a] in their name : {count}\n////////////////////////////////////////////////\n");
        }

    }
}