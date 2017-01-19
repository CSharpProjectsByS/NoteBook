using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                fileService.isCompressChecked = true;
            else
                fileService.isCompressChecked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                fileService.isCryptChecked = true;
            else
                fileService.isCryptChecked = false;   
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            ContentOfFileArea.Clear();
            chooseProperFileForRead();
            fileService.openFile();    
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            chooseProperPathForWrite();
            fileService.saveToFile();
        }

        private void ClearTextAreaButton_Click(object sender, EventArgs e)
        {
            ContentOfFileArea.Clear();
        }


        private void chooseProperFileForRead()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Otwieranie pliku";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileService.locationOfFile = openFileDialog.FileName;
                fileService.choosenExtension = Path.GetExtension(openFileDialog.FileName);
                Console.WriteLine("Location: " + fileService.locationOfFile);
                Console.WriteLine("Wybrane rozszerzenie: " + fileService.choosenExtension);
                
            }
            else
            {
                MessageBox.Show("Nie udało się utowrzyć pliku.");
            }
        }

        private void chooseProperPathForWrite()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Zapisz plik jako: ";
            string extension = fileService.getPreferExtension();
            saveFileDialog.DefaultExt = extension;
            saveFileDialog.Filter = "Pliki (*. "+ extension +") | *." + extension + " | All files(*.*) | *.*";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileService.locationOfFile = saveFileDialog.FileName;
            }
        }
    }
}
