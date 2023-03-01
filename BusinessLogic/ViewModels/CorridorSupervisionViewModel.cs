using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class CorridorSupervisionViewModel
    {
        public int CorridorId { get; set; }
        public int BasicEmpId { get; set; }
        public string BasicEmpName { get; set; } = string.Empty;
        public int SpareEmpId { get; set; } 
        public string SpareEmpName { get; set; } = string.Empty;
        public string FromDate { get; set; } = string.Empty;
        public string ToDate { get; set; } = string.Empty;
        public int DepId { get; set; }
        public string DepName { get; set; } = string.Empty;
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
    }
}
