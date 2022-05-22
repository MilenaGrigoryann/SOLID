using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Employee
    {

        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(Employee em)
        {
            Console.WriteLine($"ID:{Employee_Id} name {Employee_Name}");
            return true;
        }
        public override string ToString()
        {
            return ($"ID:{Employee_Id} name {Employee_Name}");
        }
    }
}

