﻿using System;

namespace OCP
{
    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }
    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            Console.WriteLine("Generate Crystal report");
        }
    }
    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            Console.WriteLine("Generate PDF report");
        }
    }

}
