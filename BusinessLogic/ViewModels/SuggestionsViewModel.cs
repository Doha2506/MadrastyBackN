using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SuggestionsViewModel
    {
        public int Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string File { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Upload { get; set; } = string.Empty;

    }
}
