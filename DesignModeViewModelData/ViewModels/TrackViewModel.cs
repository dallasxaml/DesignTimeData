﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeViewModelData.ViewModels
{
    public class TrackViewModel
    {
        public string Name { get; set; }
        public List<SessionHeaderViewModel> Sessions { get; set; }
    }
}
