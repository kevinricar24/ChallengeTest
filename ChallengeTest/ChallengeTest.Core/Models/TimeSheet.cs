using System;

namespace ChallengeTest.Core.Models
{
    public class TimeSheet
    {
        public int TimesheetId { get; set; }
        public DateTime DateWorked { get; set; }
        public int HoursWorked { get; set; }
        public Employee Employee { get; set; }
    }
}
