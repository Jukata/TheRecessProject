using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecessProjectClassLibrary.Objects.Interfaces;
using TheRecessProjectClassLibrary.Objects.SchoolObjects;

namespace TheRecessProjectClassLibrary.Objects.SchoolObjects
{
    public class Discipline : IDiscipline
    {
        // fields
        private string _name;
        private int _id;
        private Teacher _disciplineTeacher;

        // properties
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 4)
                {
                    _name = value;
                }

                else
                {
                    throw new ArgumentException("Discipline's name must be longer than 4 characters");
                }
            }
        }

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
                    throw new ArgumentException("ID must be between 0 and 10000");
                }
            }
        }

        public Teacher DisciplineTeacher
        {
            get
            {
                return _disciplineTeacher;
            }

            set
            {
                _disciplineTeacher = value;
            }
        }
    }
}
