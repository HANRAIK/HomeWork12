using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Repository
    {
        static Random r;

        static Repository()
        {
            r = new Random();
        }

        /// <summary>
        /// Коллекция сотрудников
        /// </summary>
        public List<Employee> EmployeeDb { get; set; }

        /// <summary>
        /// Коллекция департаментов
        /// </summary>
        public List<Department> DepartmentDb { get; set; }

        private Repository(int countDepartment, int countEmployee)
        {
            EmployeeDb = new List<Employee>();
            DepartmentDb = new List<Department>();

            for (int i = 0; i < countDepartment; i++)
            {
                DepartmentDb.Add(new Department($"Департамент_{i + 1}", i + 1));
            }

            for (int i = 0; i < countEmployee; i++)
            {
                EmployeeDb.Add(new Employee($"Surname_{i + 1}", $"Name_{i + 1}", r.Next(18, 30), r.Next(DepartmentDb.Count)+1));
            }

        }

        public static Repository CreateRepository (int countDepartment = 10, int countEmployee = 100)
        {
            return new Repository(countDepartment, countEmployee); 
        }
    }
}
