using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class TeamMemberViewModel
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; } = string.Empty;
        public int EmoployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;

    }
}
