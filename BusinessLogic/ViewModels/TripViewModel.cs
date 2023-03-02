using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class TripViewModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string Loction { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Goals { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public int Type { get; set; }
        public int TransportationType { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int LevelId { get; set; }





    }
}
