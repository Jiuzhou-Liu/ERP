using System;

namespace Model
{

    public class T_Equipment
    {
        private int eID;
        public int EID
        {
            get { return eID; }
            set { eID = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private int cID;
        public int CID
        {
            get { return cID; }
            set { cID = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string sN;
        public string SN
        {
            get { return sN; }
            set { sN = value; }
        }

        private int uID;
        public int UID
        {
            get { return uID; }
            set { uID = value; }
        }

        private string useDuration;
        public string UseDuration
        {
            get { return useDuration; }
            set { useDuration = value; }
        }

        private string hardwareOperate;
        public string HardwareOperate
        {
            get { return hardwareOperate; }
            set { hardwareOperate = value; }
        }

        private string softwareOperate;
        public string SoftwareOperate
        {
            get { return softwareOperate; }
            set { softwareOperate = value; }
        }

        private string faultOperate;
        public string FaultOperate
        {
            get { return faultOperate; }
            set { faultOperate = value; }
        }

        private string defectCondition;
        public string DefectCondition
        {
            get { return defectCondition; }
            set { defectCondition = value; }
        }

        private string useSuggestions;
        public string UseSuggestions
        {
            get { return useSuggestions; }
            set { useSuggestions = value; }
        }

        private string other;
        public string Other
        {
            get { return other; }
            set { other = value; }
        }
    }
}
