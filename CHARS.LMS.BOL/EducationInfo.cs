using System;
using System.Collections.Generic;
using System.Text;

namespace LibaryManagmentSystem.Info
{
    public class EducationInfo
    {
        private Int64 mSyskey;
        public Int64 Syskey
        {
            get { return mSyskey; }
            set { mSyskey = value; }
        }

        private string mCode;
        public string Code
        {
            get { return mCode; }
            set { mCode = value; }
        }

        private string mDescription;
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
       

    }
}
