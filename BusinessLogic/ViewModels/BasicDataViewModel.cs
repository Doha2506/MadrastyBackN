using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class BasicDataViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FileNumber { get; set; }
        public int IdentittyNumber { get; set; }
        public int Qualification { get; set; }
        public string RegisterDate { get; set; } = string.Empty;
        public int CivilNumber { get; set; }
        public int ExpirationYear { get; set; }
        public int EmployeeId { get; set; }

    }
}
