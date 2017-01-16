using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class Writer
    {
        public Writer()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mCode;
        private string mWriterName;
        private string mScriptName;
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
        public string WriterName
        {
            get { return mWriterName; }
            set { mWriterName = value; }
        }
        public string ScriptName
        {
            get { return mScriptName; }
            set { mScriptName = value; }
        }
        #endregion

        #region "Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mCode = "";
            mWriterName = "";
            mScriptName = "0";
        }
        #endregion
       
    }
}
