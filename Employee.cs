using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Employee  : IComparable<Employee>
    {
        /// <summary>
        ///  Фамилия сотрудника
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Зарплата сотрудника
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Уникальный идентификатор департамента, в котором работает сотрудник
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Название департамента, в котором работает сотрудник
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="surname">Фамилия сотрудника</param>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="age">Возраст сотрудника</param>
        /// <param name="departamentId">Уникальный идентификатор департамента, в котором работает сотрудник</param>
        /// <param name="position">Должность сотрудник</param>
        /// <param name="salary">Зарплата сотрудника</param>
        /// <param name="departamentName">Название департамента, в котором работает сотрудник</param>
        public Employee(string surname, string name, int age, int departmentId)
        {
            Surname = surname;
            Name = name;
            Age = age;
            DepartmentId = departmentId;

            // инициализирую переменные, которые будут использоваться в потомках данного класса
            Position = "";
            Salary = 0;
            DepartmentName = "";
        }

        public override string ToString()
        {
            return $"{Name,7} {Age,3} {DepartmentId,3}";
        }

        /// <summary>
        /// Правила сортировки 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Employee p)
        {
            return this.Name.CompareTo(p.Name);
        }



        /// <summary>
        /// Возврат данных о сотруднике в консоль
        /// </summary>
        /// <returns></returns>
        //public virtual void Print()
        //{
        //    Console.WriteLine(String.Format("{0,50} |  Salary:{1,6} | ",  //Name:{3,5} |  Age:{4,10} | Surname:{5,15}",
        //        this.Position,
        //        this.Salary,
        //        this.Name,
        //        this.Age,
        //        this.Surname,
        //        this.Dep
        //        ));
        //}
    }
}
