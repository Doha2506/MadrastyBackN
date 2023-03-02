using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class VisitTypeViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public int IsDate { get; set; }
        public string Date { get; set; } = string.Empty;
        public int IsPhone { get; set; }
        public string Phone { get; set; } = string.Empty;
        public int IsStartTime { get; set; }    
        public string StartTime { get; set; } = string.Empty;
        public int IsEndTime { get; set; }
        public string EndTime { get; set; } = string.Empty;
        public int IsName { get; set; }
        public string Name { get; set; } = string.Empty;
        public int IsTopic { get; set; }
        public string Topic { get; set; } = string.Empty;
        public int IsInstruction { get; set; }
        public string Instruction { get; set; } = string.Empty;
        public int IsJob { get; set; }
        public string Job { get; set; } = string.Empty;
        public int IsNotes { get; set; }
        public string Notes { get; set; } = string.Empty;
        public int IsDepartment { get; set; }
        public string Department { get; set; } = string.Empty;
        public int IsVNote { get; set; }
        public string VNote { get; set; } = string.Empty;
        public int IsVpic { get; set; }
        public string Vpic { get; set; } = string.Empty;
        public int IsFromEmployee { get; set; }
        public string FromEmployee { get; set; } = string.Empty;
        public int IsToEmployee { get; set; }
        public string ToEmployee { get; set; } = string.Empty;
        public int IsTakeem { get; set; }
        public string Takeem { get; set; } = string.Empty;

    }
}
