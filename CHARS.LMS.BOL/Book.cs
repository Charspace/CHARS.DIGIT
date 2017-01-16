using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class Book
    {
        public Book()
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
        private string mCategory;
        private string mWriter;
        private string mPublisher;
        private string mPublishDate;
        private string mPublishTimes;
        private string mDonator;
        private string mDinationDate;
        private string mBookValue;
        private string mBookStatus;
        private string mRentDuration;
        private string mRemark;
        private string mPicture;
        //private byte[] mPicture;

        


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
        public string Library
        {
            get { return mLibrary; }
            set { mLibrary = value; }
        }
         
        
        public string Category
        {
            get { return mCategory; }
            set { mCategory = value; }
        }
        public string Writer
        {
            get { return mWriter; }
            set { mWriter = value; }
        }
        public string Publisher
        {
            get { return mPublisher; }
            set { mPublisher = value; }
        }
        public string PublishDate
        {
            get { return mPublishDate; }
            set { mPublishDate = value; }

        }
        public string PublishTimes
        {
            get { return mPublishTimes; }
            set { mPublishTimes = value; }

        }
        public string Donator
        {
            get { return mDonator; }
            set { mDonator = value; }
        }
        public string DonationDate
                {
                    get { return mDinationDate; }
                    set { mDinationDate = value; }
                }
        public string BookValue
                {
                    get { return mBookValue; }
                    set { mBookValue = value; }
                }
        public string RentDuration
                {
                    get { return mRentDuration; }
                    set { mRentDuration = value; }
                }
        public string Remark
                {
                    get { return mRemark; }
                    set { mRemark = value; }
                }
        //public byte[] Picture
        //        {
        //            get { return mPicture; }
        //            set { mPicture = value; }
        //        }
        public string Picture
        {
            get { return mPicture; }
            set { mPicture = value; }
        }
        public string BookStatus
        {
            get { return mBookStatus; }
            set { mBookStatus = value; }
        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
          mAsk="0";
          mTS="0";
          mUD="0";
          mCode = "";
          mDescription = "";
          mLibrary = "0";
          mCategory = "0";
          mWriter = "0";
          mPublisher = "0";
          mPublishDate = "0";
          mPublishTimes = "";
          mDonator = "";
          mDinationDate = "";
          mBookValue = "0";
          mRentDuration = "0";
          mRemark = "";
          mPicture = "";
          //byte[] mPicture="0";
          mBookStatus = "0";
        }
        #endregion

    }
}

