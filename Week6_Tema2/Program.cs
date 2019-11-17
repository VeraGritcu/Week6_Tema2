using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Tema2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Vera", "", "Gritcu",123456, "Iasi", "0752390308", "Vera.Gritcu@yahoo.com",
                University.Al_I_Cuza, Faculty.FEAA, Speciality.Accounting, "Course" );

            var s2 = s.Clone();

            s.EMail = "V.G@gmail.com";

            var p = new Person("Vera");
            Console.WriteLine(p.ToString());
        }

        public enum University
        {
            Al_I_Cuza,
            Gheorge_Asachi,
            Ion_Ionescu_de_la_Brad
        }
        
        public enum Faculty
        {
            FEAA,
            Biology,
            Mechanics,
            Agricultura,
            Horticultura            
        }

        public enum Speciality
        {
            Marketing,
            Statistics,
            Accounting,
            Biochimics,
            Ecology_and_Environment_Protection,
            Engines,
            Consumer_and_Environment_Protection,
            Agricultural_Biotechnologies

        }

        
    }
}
