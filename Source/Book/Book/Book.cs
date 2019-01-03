using System;
using ReadingNamespace;
using IPrintableNamespace;

namespace BookNamespace
{
    /// <summary>
    /// Book class, inhereting from ReadingMaterial parent
    /// </summary>
    public class Book : ReadingMaterial, IPrintable
    {
        /// <summary>
        /// variables
        /// </summary>
        private string strISBN;
        private bool isHardCover;

        /// <summary>
        /// constructors
        /// </summary>
        public Book()
            : base()
        {
            strISBN = "12345";
            isHardCover = false;
        }
        public Book(string inTitle)
            : base(inTitle)
        {
            strISBN = "12345";
            isHardCover = false;
        }
        public Book(string inTitle, string inAuthorFirstName, string inAuthorLastName, string inPublisher, DateTime inDatePublished, string inISBN, bool inIsHardCover)
            : base(inTitle, inAuthorFirstName, inAuthorLastName, inPublisher, inDatePublished)
        {
            strISBN = inISBN;
            isHardCover = inIsHardCover;
        }

        /// <summary>
        /// properties
        /// </summary>
        public string ISBN
        {
            get
            {
                return strISBN;
            }
            set
            {
                strISBN = value;
            }
        }
        public bool IsHardCover
        {
            get
            {
                return isHardCover;
            }
            set
            {
                isHardCover = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + " - ISBN: " + strISBN;
        }
        public string GetHardCopyOption()
        {
            return "Bookstore";
        }
    }
}