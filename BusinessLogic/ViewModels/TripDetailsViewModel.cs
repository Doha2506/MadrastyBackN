using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class TripDetailsViewModel
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;

    }
}
