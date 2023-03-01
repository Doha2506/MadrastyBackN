using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class CorrMeetingViewModel
    {
        public int CorrMeetId { get; set; }
        public string CorrMeetDate { get; set; } = string.Empty;
        public string CorrMeetTime { get; set; } = string.Empty;
        public string CorrMeetLoc { get; set; } = string.Empty;

    }
}
