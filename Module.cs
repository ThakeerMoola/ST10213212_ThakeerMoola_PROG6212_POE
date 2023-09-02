using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModuleLibrary
{
    public class Module
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int ClassHoursPerWeek { get; set; }


        public double SelfStudyHoursPerWeek { get; set; }

        public double RemainingHoursThisWeek { get; set; }

        public List<StudyRecord> RecordedHours { get; set; } = new List<StudyRecord>();
    }

    public class StudyRecord
    {
        public DateTime Date { get; set; }
        public double Hours { get; set; }
    }
}