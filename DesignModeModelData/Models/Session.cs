using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpdateControls.Fields;

namespace DesignModeModelData.Models
{
    public class Session
    {
        private readonly Speaker _speaker;
        private Independent<string> _title = new Independent<string>();
        private Independent<Room> _room = new Independent<Room>();
        private Independent<DateTime> _time = new Independent<DateTime>();

        public Speaker Speaker
        {
            get { return _speaker; }
        }

        public string Title
        {
            get { return _title; }
            set { _title.Value = value; }
        }

        public Room Room
        {
            get { return _room; }
            set { _room.Value = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time.Value = value; }
        }
    }
}
