using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class Library
    {
        public Library()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mCode;
        private string mDescription;
        private string mRendDuration;
        private string mFontNamer;
        private string mFontSize;
        private string mAddress;
        private string mCity;
        private string mTownship;
        private string mDivision;
        private string mCountry;
        private string mPurpose;
        private string mEmail;
        private string mWebSite;
        private string mFacebookPage;
        private string mFounder;
        private string mFoundDate;
        //private byte[] mLogo;
        private string mLogo;      


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
        public string FontNamer
        {
            get { return mFontNamer; }
            set { mFontNamer = value; }
        }
        public string FontSize
        {
            get { return mFontSize; }
            set { mFontSize = value; }
        }
        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }
        public string City
        {
            get { return mCity; }
            set { mCity = value; }

        }
        public string Township
        {
            get { return mTownship; }
            set { mTownship = value; }

        }
        public string Division
        {
            get { return mDivision; }
            set { mDivision = value; }
        }
        public string Country
                {
                    get { return mCountry; }
                    set { mCountry = value; }
                }
        public string Purpose
                {
                    get { return mPurpose; }
                    set { mPurpose = value; }
                }
        public string Email
                {
                    get { return mEmail; }
                    set { mEmail = value; }
                }
        public string WebSite
                {
                    get { return mWebSite; }
                    set { mWebSite = value; }
                }
        public string FacebookPage
                {
                    get { return mFacebookPage; }
                    set { mFacebookPage = value; }
                }
        public string Founder
                {
                    get { return mFounder; }
                    set { mFounder = value; }
                }
        public string FoundDate
                {
                    get { return mFoundDate; }
                    set { mFoundDate = value; }
                }
        public string Logo
                {
                    get { return mLogo; }
                    set { mLogo = value; }
                }
        //public byte[] Logo
        //{
        //    get { return mLogo; }
        //    set { mLogo = value; }
        //}
       

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
          mAsk="0";
          mTS="0";
          mUD="0";
          mCode = "";
          mDescription = "";
          mRendDuration = "0";
          mFontNamer = "";
          mFontSize = "0";
          mAddress = "";
          mCity = "";
          mTownship = "";
          mDivision = "";
          mCountry = "";
          mPurpose = "";
          mEmail = "";
          mWebSite = "";
          mFacebookPage = "";
          mFounder = "";
          mFoundDate = "";
          mLogo = "";
        }
        #endregion

    }
}


