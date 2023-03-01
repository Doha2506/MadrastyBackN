using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsenceStudent
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public int StudentId { get; set; }
        public int Flag { get; set; }
        public string Reasons { get; set; } = string.Empty;

    }
}
