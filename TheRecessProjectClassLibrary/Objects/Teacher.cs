using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecessProjectClassLibrary.Objects
{
    public class Teacher : Person
    {
        public Teacher (string name, int age, string address, string gender)
            : base (name, age, address, gender)
        {

        }
    }
}
