using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecessProjectClassLibrary.Objects
{
    public class Student : Person
    {
        // constructor
        public Student (string name, int id, string gender, int age, string address, int classId)
            : base (name, age, address, gender)
        {
            _id = id;
            _classId = classId;
        }

        // fields

        private int _id;
        private int _classId;


        // properties
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                if (value > 0 && value < 10000)
                {
                    _id = value;
                }

                else
                {
                    throw new ArgumentException("ID must be a positive number and less than 10000");
                }
                
            }
        }

        public int ClassId
        {
            get
            {
                return _classId;
            }

            set
            {
                if (value < 20 && value > 0)
                {
                    _classId = value;
                }

                else
                {
                    throw new ArgumentException("Class ID must be between 0 and 20");
                }
            }
        }


    }
}
