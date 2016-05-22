using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRecessProjectClassLibrary.Objects.Interfaces
{
    interface IHuman
    {
        string Name { get; set; }
        string Speak(string speech);
        string Gender { get; set; }
    }
}
