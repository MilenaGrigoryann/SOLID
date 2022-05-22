using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ReportGeneration
    {

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        /// <param name="="status"></param>
        public void GenerateReport(Employee em, bool status)
        {
            if (status == true)
                Console.WriteLine($"The insertion of {em} is successful");
            else
                Console.WriteLine($"The insertion of {em} is failed");
        }
    }
}
