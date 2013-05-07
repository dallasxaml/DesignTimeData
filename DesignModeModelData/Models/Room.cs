using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpdateControls.Fields;

namespace DesignModeModelData.Models
{
    public class Room
    {
        private Independent<string> _number = new Independent<string>();

        public string Number
        {
            get { return _number; }
            set { _number.Value = value; }
        }
    }
}
