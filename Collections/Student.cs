using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Student   // Task 2.1 Contains 3 properties
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PIN { get; set; }

        public string StudendtDetails()
        {
            return $"------------------------------------------\n Name : {Name}\n Surname : {Surname}\n PIN : {PIN}\n------------------------------------------";
        }
    }
}
