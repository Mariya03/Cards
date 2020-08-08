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
using System.Net.Mime;

namespace Cards
{
    public partial class Desk : Form
    {
        private string folderPath = null;
        private string[] fileNames = null;
        private Random rand = new Random();

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;            
        }

        private string SelectFolder()
        {
            var selectFolderDialog = new FolderBrowserDialog();
            DialogResult result = selectFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolderDialog.SelectedPath))
            {
                return selectFolderDialog.SelectedPath;
            }
            return null;
        }

        private void LoadCards_Click(object sender, EventArgs e)
        {
            PictureBox filePictureBox = null;

            //folderPath = @"C:\Users\Elchin\Downloads\Playing Cards\Playing Cards\playing_card_images\face";
            folderPath = SelectFolder();
            if(folderPath == null)
            {
                return;
            }

            fileNames = Directory.GetFiles(folderPath);            

            foreach(var fileName in fileNames)
            {
                filePictureBox = new PictureBox()
                {
                    Height = 100,
                    Width = 70,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = rand.Next(0, 800),
                    Top = rand.Next(50, 600),
                    Image = Image.FromFile(fileName)
                };
                this.Controls.Add(filePictureBox); 
            }
        }
    }
}
