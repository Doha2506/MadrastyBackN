using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SpeakingDisorderDetailsSecond
    {
        public int Id { get; set; }
        public int SpeakingDisorderId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Results { get; set; } = string.Empty;
    }
}
