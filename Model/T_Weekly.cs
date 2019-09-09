using System;

namespace Model
{

    public class T_Weekly
    {
        private int wID;
        public int WID
        {
            get { return wID; }
            set { wID = value; }
        }

        private int uID;
        public int UID
        {
            get { return uID; }
            set { uID = value; }
        }

        private string _This;

    public string This
        {
            get { return _This; }
            set { _This = value; }
        }

        private string next;
        public string Next
        {
            get { return next; }
            set { next = value; }
        }

        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        private DateTime dateTime;
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
    }
}
