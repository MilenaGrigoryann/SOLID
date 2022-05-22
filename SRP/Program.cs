using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee { Employee_Id = 1234 , Employee_Name = "Ben"};         
            ReportGeneration reporter = new ReportGeneration();
            bool status = em.InsertIntoEmployeeTable(em);
            reporter.GenerateReport(em, status);

        }
    }
}
