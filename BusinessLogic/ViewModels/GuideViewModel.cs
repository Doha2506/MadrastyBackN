using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class GuideViewModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string Services { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

    }
}
