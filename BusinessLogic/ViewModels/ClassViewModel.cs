using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ClassViewModel
    {
        public int ClassId { get; set; }
        public string ClassMr7la { get; set; } = string.Empty;
        public string ClassLevel { get; set; } = string.Empty;
        public string ClassCorr { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public int EmpId { get; set; }
        public int ClassCount { get; set; }
    }
}
