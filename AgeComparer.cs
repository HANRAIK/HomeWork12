using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class AgeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            int a = x.Age; //Convert.ToInt32(x[1]);
            int b = y.Age;//Convert.ToInt32(y[1]);

            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }

            return 0;
        }
    }
}
