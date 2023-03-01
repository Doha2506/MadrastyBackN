using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ChangeBranchViewModel
    {
        public int BranchId { get; set; }
        public string BranchLevel { get; set; } = string.Empty;
        public string BranchClass { get; set; } = string.Empty;
        public string BranchStudent { get; set; } = string.Empty;
        public string BranchFrom { get; set; } = string.Empty;
        public string BranchTo { get; set; } = string.Empty;

    }
}
