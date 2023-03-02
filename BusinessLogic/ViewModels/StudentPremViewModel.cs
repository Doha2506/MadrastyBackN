using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class StudentPremViewModel
    {
        public int Id { get; set; }
        public string Date { get; set; } = string.Empty;
        public string LeaveTime { get; set; } = string.Empty;
        public string ArriveTime { get; set; } = string.Empty;
        public string LevelName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ParentType { get; set; } = string.Empty;

    }
}
