using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterWage
{

    class Job
    {
        public double Wage { get; set; }
        public int Hours { get; set; }

        public double WagePerWeek {
            get {return Wage * Hours;}
        }

        public double WagePerYear{
            get{return WagePerWeek * 52;}
        }

        public Job() { 
            Wage = 10.00;
            Hours = 40;
        }

        public string JobDetails {
            get {
                string s = "";
                s += "Gross wage per week: " + WagePerWeek.ToString("C", CultureInfo.CurrentCulture) + "\n";
                s += "Gross wage per year: " + WagePerYear.ToString("C", CultureInfo.CurrentCulture) + "\n";
                s += "Wage per week: " + (WagePerWeek * 0.7).ToString("C", CultureInfo.CurrentCulture) + "\n";
                s += "Wage per year: " + (WagePerYear * 0.7).ToString("C", CultureInfo.CurrentCulture) + "\n";
             
                return s;
            }
        
        }

        public static double PercentCompareWage(Job j1, Job j2) {
            double result = (j1.WagePerYear / j2.WagePerYear);
            return Math.Min(Math.Max(result,0),1);

        }

        public static Job Compare(Job j1, Job j2) {
            if (j1.WagePerYear > j2.WagePerYear) return j1;
            return j2;
        }

    }
}
