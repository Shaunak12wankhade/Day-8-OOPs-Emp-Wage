using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewages
{
    class UC1Attendance
    {
        public static void Attendance()
        {
            int IS_FULL_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_Time)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }
    }
}
