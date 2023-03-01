using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class CatchRecieptViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int SerialNumber { get; set; }
        public string Region { get; set; } = string.Empty;
        public int CenterNumber { get; set; }
        public string SchoolName { get; set; } = string.Empty;
        public int DinarValue { get; set; }
        public int FelsValue { get; set; }
        public string DateOfReciept { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public int EmpId { get; set; }
        public string TotalInArabic { get; set; } = string.Empty;
        public string CacheOrCheck { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
    }
}
