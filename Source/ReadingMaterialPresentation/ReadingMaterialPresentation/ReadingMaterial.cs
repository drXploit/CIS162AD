using System;
/*
 * Author: Jeremy Bowne
 * File: ReadingMaterial.cs
 * Begin Date: 10/21/2018
 * Exercise: Chapter 11 exercise 8
 * 
 * Create a base class titled ReadingMaterial. Include subclasses of
 * Online, Book, and Magazine. Design your classes so that common
 * characteristics are placed in the ReadingMaterial class. Provide the
 * unique characteristics of the subclasses in the derived classes. Define an
 * interface called IPrintable that has a method that returns as a string
 * how it is available in hard copy form (i.e., printable PDF, from a publisher
 * or from a bookstore). Include a presentation class to test your design. 
 * 
 * */
namespace ReadingNamespace
{
    public class ReadingMaterial
    {
        /// <summary>
        /// global variables
        /// </summary>
        private string strTitle;
        private string strAuthorFirstName;
        private string strAuthorLastName;
        private string strPublisher;
        private DateTime datePublished;

        /// <summary>
        /// constructors
        /// </summary>
        public ReadingMaterial()
        {
            strTitle = "";
            strAuthorFirstName = "";
            strAuthorLastName = "";
            strPublisher = "";
            datePublished = new DateTime(2017, 12, 25);
        }
        public ReadingMaterial(string inTitle)
        {
            strTitle = inTitle;
            strAuthorFirstName = "";
            strAuthorLastName = "";
            strPublisher = "";
            datePublished = new DateTime(2017, 12, 25);
        }
        public ReadingMaterial(string inTitle, string inAuthorFirstName, string inAuthorLastName, string inPublisher, DateTime inDatePublished)
        {
            strTitle = inTitle;
            strAuthorFirstName = inAuthorFirstName;
            strAuthorLastName = inAuthorLastName;
            strPublisher = inPublisher;
            datePublished = inDatePublished;
        }

        /// <summary>
        /// overrides
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return strTitle + " by " + strAuthorFirstName + " " + strAuthorLastName + " published by " +
                strPublisher + " on " + datePublished.ToString("MMMM dd, yyyy") + ".";
        }


        /// <summary>
        /// properties
        /// </summary>
        public string Title
        {
            get
            {
                return strTitle;
            }
            set
            {
                strTitle = value;
            }
        }
        public string AuthorFirstName
        {
            get
            {
                return strAuthorFirstName;
            }
            set
            {
                strAuthorFirstName = value;
            }
        }
        public string AuthorLastName
        {
            get
            {
                return strAuthorLastName;
            }
            set
            {
                strAuthorLastName = value;
            }
        }
        public string Publisher
        {
            get
            {
                return strPublisher;
            }
            set
            {
                strPublisher = value;
            }
        }
        public DateTime DatePublished
        {
            get
            {
                return datePublished;
            }
            set
            {
                datePublished = value;
            }
        }
    }
}
