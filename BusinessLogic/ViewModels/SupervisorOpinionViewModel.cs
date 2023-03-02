using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SupervisorOpinionViewModel
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
        public string Date { get; set; } = string.Empty;
        public string Report { get; set; } = string.Empty;
        public string SupervisorOpinion { get; set; } = string.Empty; 
        public string DepartmentManagerOpinion { get; set; } = string.Empty;

    }
}
