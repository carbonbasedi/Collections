using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Group
    {
        public string Name { get; set; }  // Task 1.1 (name property)

        public string GetDetails()
        {
            return $"********************\nGroup Name :{Name}\n********************";
        }
    }
}
