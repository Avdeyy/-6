using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__6
{
    internal class Department
    {
        public string Title { get; set; }
        public List<Person> Employees = new List<Person>();
        public int NumberOfVacancies { get; set; }
        virtual public void StaffSelection(List<Person> Candidates)
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                if (Candidates[i].Score >= 3.0)
                {
                    Employees.Add(Candidates[i]);
                }
            }
            for (int i = 0; i < Candidates.Count; i++)
            {
                for (int j = 0; j < Employees.Count; j++)
                    if (Candidates[i] == Employees[j])
                    {
                        Candidates.Remove(Candidates[i]);
                    }
            }
        }
        public string PrintEmployees()
        {
            string result = "==Список сотрудников департамента " + Title + "==\n";
            foreach (var item in Employees)
            {
                result += item.Name + "\n";
            }
            result += "--------------";
            return result;
        }

    }

    class ElectricianDepartment : Department
    {
        override public void StaffSelection(List<Person> Candidates)
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                if ((Candidates[i].Score >= 4.5) && (Candidates[i].PersonSpeciality == (Speciality)0))
                {
                    Employees.Add(Candidates[i]);
                    Candidates.Remove(Candidates[i]);
                }
            }
            for (int i = 0; i < Candidates.Count; i++)
            {
                for (int j = 0; j < Employees.Count; j++)
                    if (Candidates[i] == Employees[j])
                    {
                        Candidates.Remove(Candidates[i]);
                    }
            }
        }
        public new string PrintEmployees()
        {
            string bresult = base.PrintEmployees();
            string[] result = bresult.Split("\n");
            string fstring = result[0];
            for (int i = 1; i < result.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < Employees.Count; j++)
                {
                    if (Employees[j].Name == result[i])
                    {
                        k++;
                        fstring += $"\n\t-{result[i]}, средний балл: {Employees[j].Score}";
                        break;
                    }
                }
            }
            fstring += $"\n{result[result.Length - 1]}";
            return fstring;
        }
    }
    class MechanicDepartment : Department
    {
        override public void StaffSelection(List<Person> Candidates)
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                if ((Candidates[i].Score >= 4.0) && (Candidates[i].Age <= 35) && (Candidates[i].PersonSpeciality == (Speciality)1))
                {
                    Employees.Add(Candidates[i]);
                    Candidates.Remove(Candidates[i]);
                }
            }
            for (int i = 0; i < Candidates.Count; i++)
            {
                for (int j = 0; j < Employees.Count; j++)
                    if (Candidates[i] == Employees[j])
                    {
                        Candidates.Remove(Candidates[i]);
                    }
            }
        }
        public new string PrintEmployees()
        {
            string bresult = base.PrintEmployees();
            string[] result = bresult.Split("\n");
            string fstring = result[0];
            for (int i = 1; i < result.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < Employees.Count; j++)
                {
                    if (Employees[j].Name == result[i])
                    {
                        k++;
                        fstring += $"\n\t-{result[i]}, возраст: {Employees[j].Age}";
                        break;
                    }
                }
            }
            fstring += $"\n{result[result.Length - 1]}";
            return fstring;
        }
    }
    class InformDepartment : Department
    {
        override public void StaffSelection(List<Person> Candidates)
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                if ((Candidates[i].Score >= 4.8) && (Candidates[i].PersonSpeciality == (Speciality)2 || Candidates[i].PersonSpeciality == (Speciality)3) && (Candidates[i].Age >= 22))
                {
                    Employees.Add(Candidates[i]);
                    Candidates.Remove(Candidates[i]);
                }
            }
            for (int i = 0; i < Candidates.Count; i++)
            {
                for (int j = 0; j < Employees.Count; j++)
                    if (Candidates[i] == Employees[j])
                    {
                        Candidates.Remove(Candidates[i]);
                    }
            }
        }
        public new string PrintEmployees()
        {
            string bresult = base.PrintEmployees();
            string[] result = bresult.Split("\n");
            string fstring = result[0];
            for (int i = 1; i < result.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < Employees.Count; j++)
                {
                    if (Employees[j].Name == result[i])
                    {
                        k++;
                        fstring += $"\n\t-{result[i]}, специальность: {Employees[j].PersonSpeciality}, возраст: {Employees[j].Age}";
                        break;
                    }
                }
            }
            fstring += $"\n{result[result.Length - 1]}";
            return fstring;
        }
    }
}
