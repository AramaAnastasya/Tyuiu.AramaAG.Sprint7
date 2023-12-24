using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AramaAG.Sprint7.Project.V11
{
    public class StaffDepartment
    {
        public string Familia { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirhtDay { get; set; }
        public int Salary { get; set; }
        public string Staff1 { get; set; }
        public int Staz { get; set; }

        public StaffDepartment()
        {

        }

        public StaffDepartment(string familia, string name, string lastName, string birhtDay, int salary, string staff, int staz)
        {
            Familia = familia;
            Name = name;
            LastName = lastName;
            BirhtDay = birhtDay;
            Salary = salary;
            Staff1 = staff;
            Staz = staz;
        }
    }
}
