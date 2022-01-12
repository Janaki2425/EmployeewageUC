using System;
namespace EmployeeWagee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePresence employeepresent = new EmployeePresence();
            employeepresent.Employee_Check_UC1();
            DailyEmployeeWage employee=new DailyEmployeeWage();
            employee.Employee_Check_UC2();
        }

    }
}

