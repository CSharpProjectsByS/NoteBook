using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    class FileService
    {
        public bool isCompressed = false;
        public bool isCrypt = false;
        public String locationOfFile = "";
        public RichTextBox contentOfTextAreaRTB;

        private List<string> allLinesInList;
        
        public FileService(RichTextBox richTextBox)
        {
            contentOfTextAreaRTB = richTextBox;
        }

        //open without checking
        public bool OpenFile()
        {
            bool isDone = false;

            if (File.Exists(locationOfFile))
            {
                PutFileToContentTextArea();
            }

            return isDone;
        }

        public void SaveToFile()
        {
            SaveContentFromContetTextAreaToFile();
        }

        private void PutFileToContentTextArea()
        {
            using (var fileStream = new FileStream(locationOfFile, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fileStream.Read(b, 0, b.Length) > 0)
                {
                    contentOfTextAreaRTB.AppendText(temp.GetString(b));
                }
            }
        }

        private void SaveContentFromContetTextAreaToFile()
        {
            using (var fileStream = new FileStream(locationOfFile, FileMode.Create))
            {
                for (int i = 0; i < contentOfTextAreaRTB.Lines.Count(); i++)
                {
                    byte[] line = new UTF8Encoding(true).GetBytes(contentOfTextAreaRTB.Lines[i] + "\n");
                    fileStream.Write(line, 0, line.Length);   
                }
                  
            }
        }
    }
}
