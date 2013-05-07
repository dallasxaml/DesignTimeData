using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeViewModelData.ViewModels
{
    public class SessionHeaderViewModel
    {
        public string Title { get; set; }
        public string Speaker { get; set; }
        public DateTime Time { get; set; }
        public string Room { get; set; }
    }
}
