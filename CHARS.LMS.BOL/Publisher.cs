using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class Publisher
    {
        public Publisher()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mCode;
        private string mDescription;
        private string mAddress;
        #endregion

        #region "public member"

        public string Ask
        {
            get { return mAsk; }
            set { mAsk = value; }
        }
        public string TS
        {
            get { return mTS; }
            set { mTS = value; }
        }
        public string UD
        {
            get { return mUD; }
            set { mUD = value; }
        }
        public string Code
        {
            get { return mCode; }
            set { mCode = value; }
        }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }
        #endregion

        #region "Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mCode = "";
            mDescription = "";
            mAddress = "0";
        }
        #endregion
       
    }
}
