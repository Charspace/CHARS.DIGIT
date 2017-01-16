using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class Member
    {
        public Member()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mCode;
        private string mDescription; 
        private string mLibrary;
        private string mMemberType; 
        private string mMemberStatus; 
        private string mRentableBook; 
        private string mEduction;    
        private string mMemberFee; 
        private string mRegistratinDate; 
        private string mStartDate; 
        private string mExpiredDate;
        private byte[] mMemberPicture; 

        #endregion
        #region "private member"
 
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
        public string Library
        {
            get { return mLibrary; }
            set { mLibrary = value; }
        }
        public string MemberType
        {
            get { return mMemberType; }
            set { mMemberType = value; }
        }
        public string MemberStatus
        {
            get { return mMemberStatus; }
            set { mMemberStatus = value; }
        }
        public string RentableBook
        {
            get { return mRentableBook; }
            set { mRentableBook = value; }
        }
        public string Eduction
        {
            get { return mEduction; }
            set { mEduction = value; }
        }
        public string MemberFee
        {
            get { return mMemberFee; }
            set { mMemberFee = value; }
        }        
        public string RegistratinDate
        {
            get { return mRegistratinDate; }
            set { mRegistratinDate = value; }
        }
        public string StartDate
        {
            get { return mStartDate; }
            set { mStartDate = value; }
        }
        public string ExpiredDate
        {
            get { return mExpiredDate; }
            set { mExpiredDate = value; }
        }        
        public byte[] MemberPicture
        {
            get { return mMemberPicture; }
            set { mMemberPicture = value; }
        }
        #endregion

        
        #region "Default Property"
          public void setDefaultValue()
        {
             mAsk ="0"; 
             mTS="0"; 
             mUD="0"; 
             mCode=""; 
             mDescription="";
             mLibrary="0"; 
             mMemberType="0"; 
             mMemberStatus="0"; 
             mRentableBook="0"; 
             mEduction="0"; 
             mMemberFee="0"; 
             mRegistratinDate="";
             mStartDate="";
             mExpiredDate="";
             //mMemberPicture =new byte[]; 
          }
        #endregion
    }
}
