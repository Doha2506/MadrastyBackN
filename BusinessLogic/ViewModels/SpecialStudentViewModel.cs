using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SpecialStudentViewModel
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int SubDepartmentId { get; set; }
        public string SubDepartmentName { get; set; } = string.Empty;
        public string ExcellenceManifestations { get; set; } = string.Empty; 
        public string SuggestedDevelopment { get; set; } = string.Empty;
        public string Results { get; set; } = string.Empty;

    }
}
