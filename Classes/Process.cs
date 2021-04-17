using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToReport.Classes
{
    public class Process
    {
        public DateTime StartDate;
        public DateTime FinishDate;
        public DateTime OverdueTime;
        public bool IsResults;

        public Process(DateTime startDate, DateTime finishDate)
        {
            StartDate = startDate;
            FinishDate = finishDate;
            IsResults = IsResult(startDate, finishDate);
        }
        public Process( DateTime finishDate)
        {
            FinishDate = finishDate;
        }
        public Process() { }
        public bool IsResult(DateTime startTime, DateTime finishTime)
        {
            return DateTime.Now > startTime;
        }
        //public DateTime GetOverdueTime(DateTime finishDate)
        //{
        //    return (DateTime.Today - finishDate.;
        //}
    }
}
