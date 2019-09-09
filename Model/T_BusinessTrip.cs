using System;

namespace Model
{

    public class T_BusinessTrip
    {
        private int bID;
        public int BID
        {
            get { return bID; }
            set { bID = value; }
        }

        private int uID;
        public int UID
        {
            get { return uID; }
            set { uID = value; }
        }

        private int cID;
        public int CID
        {
            get { return cID; }
            set { cID = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private DateTime beginDate;
        public DateTime BeginDate
        {
            get { return beginDate; }
            set { beginDate = value; }
        }

        private DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private string place;
        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        private DateTime setOutDate;
        public DateTime SetOutDate
        {
            get { return setOutDate; }
            set { setOutDate = value; }
        }

        private string cost;
        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private string reason;
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
    }
}
