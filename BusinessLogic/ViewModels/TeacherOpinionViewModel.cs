using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class TeacherOpinionViewModel
    {
        public int Id { get; set; }
        public int TakemId { get; set; }
        public int EmployeeId { get; set; }
        public int IsAgree { get; set; }
        public string Notes { get; set; } = string.Empty;

    }
}
