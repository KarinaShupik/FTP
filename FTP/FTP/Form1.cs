using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FTP
{
    public partial class Form1 : Form
    {

        private FtpWebRequest ftpRequest;
        private FtpWebResponse ftpResponse;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                FadList.Items.Clear();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    FadList.Items.Add(reader.ReadLine());
                }
                MessageBox.Show(response.WelcomeMessage);
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при підключенні до FTP сервера: " + ex.Message);
            }
        }

        //завантажити на FTP
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text +
                        txtDir3.Text + openFileDialog1.SafeFileName);
                    request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    byte[] file = System.IO.File.ReadAllBytes(textBox1.Text);
                    Stream strz = request.GetRequestStream();
                    strz.Write(file, 0, file.Length);
                    strz.Close();
                    strz.Dispose();

                    MessageBox.Show(openFileDialog1.SafeFileName + " завантажено");
                }
                else
                {
                    MessageBox.Show(openFileDialog1.SafeFileName + " не завантажено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні файлу на FTP сервер: " + ex.Message);
            }
        }

        //створити каталог
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = txtDir1.Text;

                if (string.IsNullOrEmpty(directoryPath))
                {
                    MessageBox.Show("Будь ласка, введіть шлях до каталогу.");
                    return;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + directoryPath);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Каталог " + directoryPath + " створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при створенні каталогу на FTP сервері: " + ex.Message);
            }
        }

        // Отримати розмір файлу
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFile1.Text;

                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Будь ласка, виберіть файл.");
                    return;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + filePath);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    long size = response.ContentLength;
                    MessageBox.Show("Розмір файлу: " + size.ToString() + " байт");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при отриманні розміру файлу: " + ex.Message);
            }
        }

        // Видалити каталог
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = txtDir2.Text;

                if (string.IsNullOrEmpty(directoryPath))
                {
                    MessageBox.Show("Будь ласка, виберіть каталог.");
                    return;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + directoryPath);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Каталог " + directoryPath + " видалено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні каталогу на FTP сервері: " + ex.Message);
            }
        }

        // Видалити файл
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFile2.Text;

                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Будь ласка, виберіть файл.");
                    return;
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + filePath);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Файл " + filePath + " видалено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні файлу на FTP сервері: " + ex.Message);
            }
        }

        //завантаження файлів для визначення розміру файлів
        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile1.Text = openFileDialog1.FileName;
            }
        }
        //завантаження файлів для створення каталога
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog1.FileName;
            }
        }

        //завантаження файлів для видалення каталогу
        private void button9_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDir2.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //завантаження файлів для створення каталогу
        private void button10_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDir1.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //команди
        private void appe_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.AppendFile;

                using (Stream fileStream = openFileDialog1.OpenFile())
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show(openFileDialog1.SafeFileName + " appended");
            }
        }

        private void dele_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + fileName);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show(fileName + " deleted");

                response.Close();
            }
        }

        private void retr_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                saveFileDialog1.Filter = "All files (*.*)|*.*";
                saveFileDialog1.FileName = fileName;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + fileName);
                    request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    using (Stream ftpStream = response.GetResponseStream())
                    using (Stream fileStream = System.IO.File.Create(saveFileDialog1.FileName))
                    {
                        ftpStream.CopyTo(fileStream);
                    }

                    MessageBox.Show(fileName + " downloaded");
                }
            }
        }

        private void mdt_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + fileName);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.GetDateTimestamp;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Modification Time of " + fileName + ": " + response.LastModified);

                response.Close();
            }
        }

        private void size_Click(object sender, EventArgs e)
        {
            string fileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fileName))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + fileName);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.GetFileSize;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("Size of " + fileName + ": " + response.ContentLength + " bytes");

                response.Close();
            }
        }

        private void nlist_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text);
            request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FadList.Items.Add(line);
                }
            }

            MessageBox.Show("NLIST completed");
        }

        private void list_Click(object sender, EventArgs e)
        {
            FadList.Items.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text);
            request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FadList.Items.Add(line);
                }
            }

            MessageBox.Show("LIST completed");
        }

        private void mkd_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtDir1.Text);
            request.Credentials = new NetworkCredential(txtHost.Text, txtPassword.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + txtDir1.Text + " created");

            response.Close();
        }
        
        private void pwd_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtDir2.Text);
            request.Credentials = new NetworkCredential(txtHost.Text, txtPassword.Text);
            request.Method = WebRequestMethods.Ftp.PrintWorkingDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + txtDir2.Text);

            response.Close();
        }

        private void rmd_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + txtDir2.Text);
            request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Directory " + txtDir2.Text + " removed");

            response.Close();
        }

        private void name_Click(object sender, EventArgs e)
        {
            string oldFileName = FadList.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(oldFileName) && !string.IsNullOrEmpty(txtNewName.Text))
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + oldFileName);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.Rename;
                request.RenameTo = txtNewName.Text;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show(oldFileName + " renamed to " + txtNewName.Text);

                response.Close();
            }
        }

        private void stor_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (Stream fileStream = openFileDialog1.OpenFile())
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show(openFileDialog1.SafeFileName + " uploaded");
            }
        }

        private void stou_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtHost.Text);
                request.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;
                using (Stream fileStream = openFileDialog1.OpenFile())
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show("File uploaded with a unique name");
            }
        }

        private void DisplayFtpDirectory(string directoryPath, TreeNode parentNode)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(directoryPath);
                ftpRequest.Credentials = new NetworkCredential(txtName.Text, txtPassword.Text);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                var ftpStream = ftpResponse.GetResponseStream();
                var reader = new StreamReader(ftpStream);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var permissions = line.Substring(0, 10);
                    var fileType = line[0] == 'd' ? FileType.Directory : FileType.File;
                    var fileName = line.Substring(56);

                    if (fileType == FileType.Directory && fileName != "." && fileName != "..")
                    {
                        var directoryNode = new TreeNode(fileName);
                        parentNode.Nodes.Add(directoryNode);
                        DisplayFtpDirectory(Path.Combine(directoryPath, fileName), directoryNode);
                    }
                    else if (fileType == FileType.File)
                    {
                        parentNode.Nodes.Add(fileName);
                    }
                }

                ftpResponse.Close();
                reader.Close();
                ftpStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public enum FileType
        {
            File,
            Directory
        }


    }
}


