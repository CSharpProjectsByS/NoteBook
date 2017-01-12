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
            allLinesInList = new List<string>();
        }

        //open without checking
        public bool OpenFile()
        {
            bool isDone = false;

            if (File.Exists(locationOfFile))
            {
                PutFileToInitalList();
                putListToContentArea();
            }

            return isDone;
        }

        public void SaveToFile()
        {
            putContentFromRTBToList();
            SaveFinalContentToFile();
        }

        private void PutFileToInitalList()
        {
            allLinesInList = new List<string>();
            using (var fileStream = new FileStream(locationOfFile, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fileStream.Read(b, 0, b.Length) > 0)
                {
                    allLinesInList.Add(temp.GetString(b));
                }
            }
        }

        private void putListToContentArea()
        {
            foreach (string line in allLinesInList)
            {
                contentOfTextAreaRTB.AppendText(line);
            }
        }

        private void SaveFinalContentToFile()
        {
            using (var fileStream = new FileStream(locationOfFile, FileMode.Create))
            {
                for (int i = 0; i < allLinesInList.Count; i++)
                {
                    byte[] line = new UTF8Encoding(true).GetBytes(allLinesInList[i]);
                    fileStream.Write(line, 0, line.Length);   
                }
                  
            }
        }


        private void putContentFromRTBToList()
        {
            allLinesInList = new List<string>();
            for (int i = 0; i < contentOfTextAreaRTB.Lines.Count(); i++)
            {
                allLinesInList.Add(contentOfTextAreaRTB.Lines[i] + "\n");
            }
        }
    }
}
