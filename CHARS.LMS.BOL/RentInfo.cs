using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class RentInfo
    {
        public RentInfo()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;                
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

        private string mBookSyskey;
        public string BookSyskey
        {
            get { return mBookSyskey; }
            set { mBookSyskey = value; }
        }

        private string mMemberSyskey;
        public string MemberSyskey
        {
            get { return mMemberSyskey; }
            set { mMemberSyskey = value; }
        }

        private int mDuration;
        public int Duration
        {
            get { return mDuration; }
            set { mDuration = value; }
        }

        private string mRentDate;
        public string RentDate
        {
            get { return mRentDate; }
            set { mRentDate = value; }
        }

        private string mExpireDate;
        public string ExpireDate
        {
            get { return mExpireDate; }
            set { mExpireDate = value; }
        }

        private string mRentStatus;
        public string RentStatus
        {
            get { return mRentStatus; }
            set { mRentStatus = value; }
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
            mBookSyskey = "0";
            mMemberSyskey = "0";
            mDuration = 0;
            mRentDate = "";
            mExpireDate = "";
            mRentStatus = "";

            
        }
        #endregion


      
   }
}
