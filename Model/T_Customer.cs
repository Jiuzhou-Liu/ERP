using System;

namespace Model
{

    public class T_Customer
    {
        private int cID;
        public int CID
        {
            get { return cID; }
            set { cID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
