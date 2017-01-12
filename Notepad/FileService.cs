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
                using (var fileStream = new FileStream(locationOfFile, FileMode.Open))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fileStream.Read(b, 0, b.Length) > 0)
                    {
                        contentOfTextAreaRTB.AppendText(temp.GetString(b));        
                    }
                }           
            }

            return isDone;
        }

        public void SaveToFile()
        {
                     
        }
    }
}
