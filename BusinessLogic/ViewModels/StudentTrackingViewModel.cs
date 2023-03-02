using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class StudentTrackingViewModel
    {
        public int Id { get; set; }
        public int TermId { get; set; }
        public int SubjectId { get; set; }
        public int LevelId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Behaviour { get; set; } = string.Empty;
        public string Book { get; set; } = string.Empty;
        public string Practice { get; set; } = string.Empty;

    }
}
