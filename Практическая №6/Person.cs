using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__6
{
    public enum Speciality { Electrician, Mechanic, Mathematician, Programmer, Lawyer };

    internal class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Speciality PersonSpeciality { get; set; }
        public double Score { get; set; }

    }
}

    
