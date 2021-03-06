using System;
using DesignModeModelData.Models;

namespace DesignModeModelData.ViewModels
{
    public class SessionHeaderViewModel
    {
        private readonly Session _session;

        public SessionHeaderViewModel(Session session)
        {
            _session = session;
        }

        public string Title
        {
            get
            {
                return _session.Title;
            }
        }

        public string Speaker
        {
            get
            {
                return _session.Speaker.Name;
            }
        }

        public DateTime Time
        {
            get
            {
                return _session.Time;
            }
        }

        public string Room
        {
            get
            {
                return _session.Room.Number;
            }
        }
    }
}
