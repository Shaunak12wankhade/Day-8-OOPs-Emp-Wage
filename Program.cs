using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to employeewages");
            //UC1Attendance.Attendance();
            //UC2Dailyempwage.DailyEmpWage();
            //UC3Parttimewage.Parttime();
            //UC4Switchcase.Wagebyswitchcase();
            //UC5Wagesformonth.Wagesformonth();
            //UC6Wagestillnoofworkingdays.Wagestillnoofworkingdaydays();
            //UC7Wagesusingclassmethod.Wageusingclassmethod();

            UC8Wagesformultiplecompanies.computeEmpWage("DMart", 20, 2, 10);
            UC8Wagesformultiplecompanies.computeEmpWage("Reliance", 10, 4, 20);

        }
}
}
