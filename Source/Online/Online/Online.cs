using System;
using ReadingNamespace;
using IPrintableNamespace;

namespace OnlineNamespace
{
    /// <summary>
    /// Online class, inhereting from ReadingMaterial parent
    /// </summary>
    public class Online : ReadingMaterial, IPrintable
    {
        /// <summary>
        /// global variables
        /// </summary>
        private string strURL;

        /// <summary>
        /// constructors
        /// </summary>
        public Online()
            : base()
        {
            strURL = "www.onlinereading.com/article1.htm";
        }
        public Online(string inTitle)
            : base(inTitle)
        {
            strURL = "www.onlinereading.com/article1.htm";
        }
        public Online(string inTitle, string inAuthorFirstName, string inAuthorLastName, string inPublisher, DateTime inDatePublished, string inURL)
            : base(inTitle, inAuthorFirstName, inAuthorLastName, inPublisher, inDatePublished)
        {
            strURL = inURL;
        }

        /// <summary>
        /// overrides
        /// </summary>
        /// <returns> string containing information about Online</returns>
        public override string ToString()
        {
            return base.ToString() + " - URL: " + strURL;
        }
        public string GetHardCopyOption()
        {
            return "Printable PDF File";
        }
        /// <summary>
        /// properties
        /// </summary>
        public string URL
        {
            get
            {
                return strURL;
            }
            set
            {
                strURL = value;
            }
        }
    }
}