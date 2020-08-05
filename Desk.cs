using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cards
{
    public partial class Desk : Form
    {
        private string folderPath = null;
        private string[] fileNames = null;

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;            
        }

        private void LoadCards_Click(object sender, EventArgs e)
        {
            folderPath = @"C:\Users\Elchin\Downloads\Playing Cards\Playing Cards\playing_card_images\face";
            fileNames = Directory.GetFiles(folderPath);
        }
    }
}
