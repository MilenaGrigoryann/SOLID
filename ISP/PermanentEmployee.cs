using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class PermanentEmployee : IAddOperation, IGetOperation
    {
        public bool AddEmployeeDetails()
        {
            Console.WriteLine("Adding Employee Details");
            return true;
        }

        public bool ShowEmployeeDetails(int employeeId)
        {
            Console.WriteLine("Showing Employee Details");
            return true;
        }
    }
}
