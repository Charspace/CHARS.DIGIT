using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class PublishTimes
    {
         public PublishTimes()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mCode;
        private string mDescription;        
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
      
        #endregion

        #region "Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mCode = "";
            mDescription = "";
        }
        #endregion
       
    }
}