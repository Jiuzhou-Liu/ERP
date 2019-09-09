using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class T_AfterSales
    {
        private int aID;
        public int AID
        {
            get { return aID; }
            set { aID = value; }
        }

        private int cID;
        public int CID
        {
            get { return cID; }
            set { cID = value; }
        }

        private int eID;
        public int EID
        {
            get { return eID; }
            set { eID = value; }
        }

        private int uID;
        public int UID
        {
            get { return uID; }
            set { uID = value; }
        }

        private string feedback;
        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        private DateTime feedbackDate;
        public DateTime FeedbackDate
        {
            get { return feedbackDate; }
            set { feedbackDate = value; }
        }

        private string reason;
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        private string processing;
        public string Processing
        {
            get { return processing; }
            set { processing = value; }
        }

        private string processingCompletedDate;
        public string ProcessingCompletedDate
        {
            get { return processingCompletedDate; }
            set { processingCompletedDate = value; }
        }
    }
}
