using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheRecessProjectClassLibrary.Objects.Interfaces;
namespace TheRecessProjectClassLibrary.Objects
{
    public abstract class Person : IHuman
    {
        // constructor
        public Person(string name, int age, string address, string gender)
        {
            _name = name;
            _age = age;
            _address = address;
            _gender = gender;
        }

        public Person()
        {

        }

        // fields
        private string _name;
        private int _age;
        private string _address;
        private string _gender;

        // properties
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) && value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name must be longer than 2 characters");
                }
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            private set
            {
                _address = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            private set
            {
                if (value != 0 && value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be a positive number, larger than 0");
                }
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                if (value == "Male" || value == "Female")
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("A person must be either \"Male\" or \"Female\"");
                }
            }
        }

        // methods
        public string Speak(string speech)
        {
            return string.Format("{0} says \"{1}\"", Name, speech);
        }
    }
}
