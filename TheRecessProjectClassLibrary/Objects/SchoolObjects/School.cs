using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecessProjectClassLibrary.Objects.SchoolObjects
{
    public class School
    {

        // constructor
        School(string name, string address, Teacher principal)
        {
            _disciplines = new List<Discipline>();
            _principal = principal;
            _teachers = new List<Teacher>();
        }

        // fields
        private List<Discipline> _disciplines;
        private List<Teacher> _teachers;
        private Teacher _principal;
        private string _name;

        // properties

        public Teacher Principal
        {
            get
            {
                return _principal;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 5)
                {
                    _name = value;
                }

                else
                {
                    throw new ArgumentException("School's name can't be with less than 5 characters");
                }
            }
        }

        //IMPLEMENT METHODS FOR GETTING/SETTINGS VALUES FROM BOTH LISTS (TEACHER/DISCIPLINE) 
    }
}
