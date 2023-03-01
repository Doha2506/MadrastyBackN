using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class FinancialFundViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Notes { get; set; } = string.Empty;


    }
}
