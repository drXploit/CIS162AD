using System;
using ReadingNamespace;
using IPrintableNamespace;

namespace MagazineNamespace
{
    /// <summary>
    /// Magazine class, inhereting from ReadingMaterial parent
    /// </summary>
    public class Magazine : ReadingMaterial, IPrintable
    {
        /// <summary>
        /// variables
        /// </summary>
        private string strIssueMonth;
        private int intYear;
        private DateTime dateRenewal;

        /// <summary>
        /// constructors
        /// </summary>
        public Magazine()
            : base()
        {
            strIssueMonth = "November";
            intYear = 2018;
            dateRenewal = new DateTime(2018, 12, 25);
        }
        public Magazine(string inTitle)
            : base(inTitle)
        {
            strIssueMonth = "November";
            intYear = 2018;
            dateRenewal = new DateTime(2018, 12, 25);
        }
        public Magazine(string inTitle, string inAuthorFirstName, string inAuthorLastName, string inPublisher, DateTime inDatePublished, string inIssue, int inYear, DateTime inRenewal)
            : base(inTitle, inAuthorFirstName, inAuthorLastName, inPublisher, inDatePublished)
        {
            strIssueMonth = inIssue;
            intYear = inYear;
            dateRenewal = inRenewal;
        }

        /// <summary>
        /// overrides
        /// </summary>
        /// <returns> string containing information about Magazine</returns>
        public override string ToString()
        {
            return base.ToString() + " - ISSUE: " + strIssueMonth + " " + intYear + " RENEWAL DATE: " +
                dateRenewal.ToString("MMM dd, yyyy");
        }
        public string GetHardCopyOption()
        {
            return "Magazine Rack";
        }

        /// <summary>
        /// properties
        /// </summary>
        public string IssueMonth
        {
            get
            {
                return strIssueMonth;
            }
            set
            {
                strIssueMonth = value;
            }
        }
        public int IssueYear
        {
            get
            {
                return intYear;
            }
            set
            {
                intYear = value;
            }
        }
        public DateTime RenewalDate
        {
            get
            {
                return dateRenewal;
            }
            set
            {
                dateRenewal = value;
            }
        }

    }
}