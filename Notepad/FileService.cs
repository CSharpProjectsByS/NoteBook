using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    class FileService
    {
        public bool isCompressChecked = false;
        public bool isCryptChecked = false;
        public String locationOfFile = "";
        public string path = "";
        public string nameOfFileWithoutExtension = "";
        public RichTextBox contentOfTextAreaRTB;

        public string defaultExtension = "txt";
        public string cryptExtension = "cry";
        public string compressedExtension = "gzip";
        public string compressedCryExtension = "cryzip";

        public string choosenExtension = "";

       

        public FileService(RichTextBox richTextBox)
        {
            contentOfTextAreaRTB = richTextBox;
        }

        public string getPreferExtension()
        {
            string extension = "";
            if (isCompressChecked && isCryptChecked)
            {
                extension = compressedCryExtension;
            }
            else if (isCompressChecked && !isCryptChecked)
            {
                extension = compressedExtension;
            }
            else if (!isCompressChecked && isCryptChecked)
            {
                extension = cryptExtension;
            }
            else 
            {
                extension = defaultExtension;
            }

            return extension;
        }

        public void openFile()
        {
            if (choosenExtension == ("." + compressedCryExtension))
            {
                openCompressedEncryptedFile();   
            }
            else if (choosenExtension == ("." + compressedExtension))
            {
                openCompressedFile();  
            }
            else if (choosenExtension == ("." + cryptExtension))
            {
                openEncryptedFile();    
            }
            else
            {
                openNormalFile();
            }
        }

        private void openNormalFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            contentOfTextAreaRTB.Text = streamReader.ReadToEnd();

            fileStream.Close();
            streamReader.Close();    
        }

        private void openCompressedFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Open, FileAccess.Read);
            GZipStream zipStream = new GZipStream(fileStream, CompressionMode.Decompress);

            StreamReader streamReader = new StreamReader(zipStream);

            contentOfTextAreaRTB.Text = streamReader.ReadToEnd();

            fileStream.Close();
            zipStream.Close();
            streamReader.Close();
        }

        private void openEncryptedFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Open, FileAccess.Read);
            AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider();

            cryptoProvider.Key = Encoding.UTF8.GetBytes(generateKey(16));
            cryptoProvider.IV = Encoding.UTF8.GetBytes(generateKey(16));

            CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoProvider.CreateDecryptor(),
                CryptoStreamMode.Read);

            StreamReader streamReader = new StreamReader(cryptoStream);
            contentOfTextAreaRTB.Text = streamReader.ReadToEnd();

            fileStream.Close();
            cryptoStream.Close();
            streamReader.Close();
        }

        private void openCompressedEncryptedFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Open, FileAccess.Read);
            AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider();

            cryptoProvider.Key = Encoding.UTF8.GetBytes(generateKey(16));
            cryptoProvider.IV = Encoding.UTF8.GetBytes(generateKey(16));

            GZipStream zipStream = new GZipStream(fileStream, CompressionMode.Decompress);
            CryptoStream cryptoStream = new CryptoStream(zipStream, cryptoProvider.CreateDecryptor(),
                CryptoStreamMode.Read);

            StreamReader streamReader = new StreamReader(cryptoStream);
            contentOfTextAreaRTB.Text = streamReader.ReadToEnd();

            streamReader.Close();
            cryptoStream.Close();
            zipStream.Close();
            fileStream.Close();

        }

        public void saveToFile()
        {
            
            if (isCompressChecked && isCryptChecked)
            {
                saveCompressedAndEncryptFile();    
            }
            else if (isCompressChecked && !isCryptChecked)
            {
                saveCompressedToFile();    
            }
            else if (!isCompressChecked && isCryptChecked)
            {
                saveEncryptFile();   
            }
            else
            {
                saveNormalToFile();        
            }

            
        }

        private void saveNormalToFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(contentOfTextAreaRTB.Text);

            streamWriter.Close();
            fileStream.Close();
        }

        private void saveCompressedToFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Create, FileAccess.Write);
            GZipStream zipStream = new GZipStream(fileStream, CompressionMode.Compress);
            StreamWriter streamWriter = new StreamWriter(zipStream);

            streamWriter.Write(contentOfTextAreaRTB.Text);

            streamWriter.Close();
            zipStream.Close();
            fileStream.Close();

        }

        private void saveEncryptFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Create, FileAccess.Write);
            AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider();

            cryptoProvider.Key = Encoding.UTF8.GetBytes(generateKey(16));
            cryptoProvider.IV = Encoding.UTF8.GetBytes(generateKey(16));

            CryptoStream cryptoStream = new CryptoStream(fileStream, cryptoProvider.CreateEncryptor(),
                CryptoStreamMode.Write);


            StreamWriter streamWriter = new StreamWriter(cryptoStream);
            streamWriter.Write(contentOfTextAreaRTB.Text);

            streamWriter.Close();
            cryptoStream.Close();
            fileStream.Close(); 
            
        }

        private void saveCompressedAndEncryptFile()
        {
            FileStream fileStream = new FileStream(locationOfFile, FileMode.Create, FileAccess.Write);
            AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider();

            cryptoProvider.Key = Encoding.UTF8.GetBytes(generateKey(16));
            cryptoProvider.IV = Encoding.UTF8.GetBytes(generateKey(16));

            GZipStream zipStream = new GZipStream(fileStream, CompressionMode.Compress);
            CryptoStream cryptoStream = new CryptoStream(zipStream, cryptoProvider.CreateEncryptor(),
                CryptoStreamMode.Write);

            StreamWriter streamWriter = new StreamWriter(cryptoStream);

            streamWriter.Write(contentOfTextAreaRTB.Text);

            streamWriter.Close();
            cryptoStream.Close();
            zipStream.Close();
            fileStream.Close();


        }

        private string generateKey(int n)
        {
            string key = "";
            for (int i = 0; i < n; i++)
            {
                key += "a";
            }

            return key;
        }
    }
}