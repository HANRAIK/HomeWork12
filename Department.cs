using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Department
    {
        /// <summary>
        /// Название департамента
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// Уникальный идентификатор департамента
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="departmentName">Название департамента</param>
        /// <param name="departmentId">Уникальный идентификатор департамента</param>
        public Department(string departmentName, int departmentId)
        {
            DepartmentName = departmentName;
            DepartmentId = departmentId;
        }

        public override string ToString()
        {
            return $"{DepartmentName,15} {DepartmentId,3}";
        }
    }
}
