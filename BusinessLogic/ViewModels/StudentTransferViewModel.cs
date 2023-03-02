using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class StudentTransferViewModel
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string CivilianId { get; set; } = string.Empty;
        public int BranchId { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public int EducationAreaId { get; set; }
        public string EducationArea { get; set; } = string.Empty;
        public int SchoolTransferId { get; set; }
        public string SchoolTransfer { get; set; } = string.Empty;
        public int NewBranch { get; set; }
        public string Date { get; set; } = string.Empty;


    }
}
