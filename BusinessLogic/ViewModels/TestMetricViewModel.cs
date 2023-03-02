using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class TestMetricViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int StudentId { get; set; }

    }
}
