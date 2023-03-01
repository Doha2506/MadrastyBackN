using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class StatusViewModel
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string StatusConcerns { get; set; } = string.Empty;
        public string StatusType { get; set; } = string.Empty;
        public int StatusTypeId { get; set; }
    }
}
