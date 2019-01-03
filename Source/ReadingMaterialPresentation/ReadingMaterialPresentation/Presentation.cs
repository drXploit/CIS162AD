using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineNamespace;
using MagazineNamespace;
using BookNamespace;

namespace ReadingMaterialPresentation
{
    public partial class Presentation : Form
    {
        //declaration of global variables
        private Online onlineArticle;
        private Magazine aMagazine;
        private Book aBook;

        // constructor for the gui
        public Presentation()
        {
            InitializeComponent();
        }

        private void PresentationFormLoad(object sender, EventArgs e)
        {
            // instantation of ReadingMaterial derived classes
            onlineArticle = new Online("How to play guitar", "John", "Michaels", "Infinite Publishing Company", new DateTime(2016, 10, 09), "guitars.com/howtoplay");
            aMagazine = new Magazine("Sports Illustrated", "Hugh", "Guhsportsfan", "Sports Illustrated Publishing", new DateTime(2018, 05, 03), "May", 2018, new DateTime(2019, 05, 01));
            aBook = new Book("The End of the World", "Contessa", "Jackson", "Doomsday Publishing", new DateTime(2013, 02, 14), "A1203Z2334", true);
            // fill the initial box values since aMagazine is the one selected
            detailsBox.Text = aMagazine.ToString();
            hardCopyBox.Text = aMagazine.GetHardCopyOption();
        }
        
        // check changed, update boxes
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (MagazineRadio.Checked)
            {
                detailsBox.Text = aMagazine.ToString();
                hardCopyBox.Text = aMagazine.GetHardCopyOption();
            }
        }

        // check changed, update boxes
        private void BookRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (BookRadio.Checked)
            {
                detailsBox.Text = aBook.ToString();
                hardCopyBox.Text = aBook.GetHardCopyOption();
            }
        }

        // check changed, update boxes
        private void OnlineRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlineRadio.Checked)
            {
                detailsBox.Text = onlineArticle.ToString();
                hardCopyBox.Text = onlineArticle.GetHardCopyOption();
            }
        }
    }
}
