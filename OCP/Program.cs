using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee { Employee_Id = 1234, Employee_Name = "Ann" };
            IReportGeneration reporter = new CrystalReportGeneraion();
            employee.InsertIntoEmployeeTable(employee);
            reporter.GenerateReport(employee);
        }
    }
}
