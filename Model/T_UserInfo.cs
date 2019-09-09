using System;

namespace Model
{

    public class T_UserInfo
    {
        private int uID;
        public int UID
        {
            get { return uID; }
            set { uID = value; }
        }

        private int gID;
        public int GID
        {
            get { return gID; }
            set { gID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private string post;
        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        private bool cIns;
        public bool CIns
        {
            get { return cIns; }
            set { cIns = value; }
        }

        private bool cDel;
        public bool CDel
        {
            get { return cDel; }
            set { cDel = value; }
        }

        private bool cUpd;
        public bool CUpd
        {
            get { return cUpd; }
            set { cUpd = value; }
        }

        private bool uIns;
        public bool UIns
        {
            get { return uIns; }
            set { uIns = value; }
        }

        private bool uDel;
        public bool UDel
        {
            get { return uDel; }
            set { uDel = value; }
        }

        private bool uUpd;
        public bool UUpd
        {
            get { return uUpd; }
            set { uUpd = value; }
        }
    }
}
