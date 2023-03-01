using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SwotViewModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string Strength { get; set; } = string.Empty;
        public string Weakness { get; set; } = string.Empty;
        public string Chances { get; set; } = string.Empty;
        public string Risks { get; set; } = string.Empty;
    }
}

