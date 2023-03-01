using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class MessageEmailViewModel
    {
        public int Id { get; set; }
        public int FromEmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int Reply { get; set; }
        public string ConnectionId { get; set; } = string.Empty;
        public int Sent { get; set; }

    }
}
