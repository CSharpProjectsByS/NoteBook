using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private FileService fileService;

        public Form1()
        {
            InitializeComponent();

            fileService = new FileService(ContentOfFileArea); 
        }

        private void ZipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ZipCheckBox.Checked)
                fileService.isCompressed = true;
            else
                fileService.isCompressed = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                fileService.isCrypt = true;
            else
                fileService.isCrypt = false;   
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile();    
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
   
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextAreaButton_Click(object sender, EventArgs e)
        {

        }


        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Otwieranie pliku";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileService.locationOfFile = openFileDialog.FileName;
                fileService.OpenFile();
            }
        }
    }
}
