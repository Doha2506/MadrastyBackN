using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AchivementLevelViewModel
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int FirstTermFails { get; set; }
        public int SecondTermFails { get; set; }
        public int AcademicFailure { get; set; }
        public int AcademicExcellence { get; set; }

    }
}
