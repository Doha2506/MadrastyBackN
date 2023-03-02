using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class VisitViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int VisitTypeId { get; set; }
        public string VisitTypeName { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string VNote { get; set; } = string.Empty;
        public int FromEmployeeId { get; set; }
        public int ToEmployeeId { get; set; }
        public int TakeemId { get; set; }
        public int Percentage { get; set; }
    }
}
