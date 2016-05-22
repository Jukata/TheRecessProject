using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecessProjectClassLibrary.Objects.SchoolObjects
{
    public class ClassRoom
    {
        // constructors
        public ClassRoom()
        {
            _students = new List<Student>();
            _disciplines = new List<Discipline>();
        }

        public ClassRoom(int id, Teacher roomTeacher)
            : this()
        {
            _id = id;
            _roomTeacher = roomTeacher;
        }


        // fields

            //IMPLEMENT METHODS FOR INTERACTING WITH THE LISTS

        public List<Student> _students;
        public List<Discipline> _disciplines;
        private int _id;
        private Teacher _roomTeacher;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public Teacher RoomTeacher
        {
            get
            {
                return _roomTeacher;
            }

            set
            {
                _roomTeacher = value;
            }
        }
    }
}
