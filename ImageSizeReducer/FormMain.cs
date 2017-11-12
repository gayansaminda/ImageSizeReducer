using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSizeReducer
{
    public partial class FormMain : Form
    {
        List<string> fileList;
        Thread progressThread;
        bool cancalRequested;
        bool setWidth;
        bool addDateLabel;
        bool replaceOriginal;

        public FormMain()
        {
            InitializeComponent();
        }

        private void checkBoxReplaceOriginal_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDestinationRoot.Enabled = !checkBoxReplaceOriginal.Checked;
            buttonBrowseDestRoot.Enabled = !checkBoxReplaceOriginal.Checked;
        }

        private void buttonBrowseSourceRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog br = new FolderBrowserDialog();
            if (br.ShowDialog() == DialogResult.OK)
            {
                textBoxSourceRoot.Text = br.SelectedPath.ToString();
            }
        }

        private void buttonBrowseDestRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog br = new FolderBrowserDialog();
            if (br.ShowDialog() == DialogResult.OK)
            {
                textBoxDestinationRoot.Text = br.SelectedPath.ToString();
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            cancalRequested = false;
            setWidth = radioButtonSetWidth.Checked;
            addDateLabel = checkBoxAddCreatedDate.Checked;
            replaceOriginal= checkBoxReplaceOriginal.Checked;

            string[] dirs = Directory.GetDirectories(textBoxSourceRoot.Text, "*", SearchOption.AllDirectories);
            List<string> dirList = new List<string>(dirs);
            dirList.Insert(0, textBoxSourceRoot.Text);

            fileList = new List<string>();

            foreach (string str in dirList)
            {
                string[] Files = Directory.GetFiles(str, "*.jpg");
                fileList.AddRange(Files);
            }
            progressBar1.Maximum = fileList.Count;

            progressThread = new Thread(ProcessFiles);
            progressThread.Start();
        }

        private void ProcessFiles()
        {
            Font font = new Font(FontFamily.GenericSerif, 25);
            int count = 0;
            StringBuilder sb = new StringBuilder();

            foreach (string fileName in fileList)
            {
                try
                {
                    Bitmap bmp = new Bitmap(fileName);
                    float width = 0;
                    float height = 0;
                    if (setWidth)
                    {
                        width = float.Parse(textBoxNewImageWidth.Text);
                        height = (width * bmp.Height) / bmp.Width;
                    }
                    else
                    {

                        height = float.Parse(textBoxNewImageHeight.Text);
                        width = (height * bmp.Width) / bmp.Height;
                    }
                    Bitmap newBmp = new Bitmap((int)width, (int)height);
                    Graphics g = Graphics.FromImage(newBmp);
                    g.DrawImage(bmp, 0, 0, newBmp.Width, newBmp.Height);

                    if (addDateLabel)
                    {
                        FileInfo fi1 = new FileInfo(fileName);
                        string text = fi1.LastWriteTime.ToString("MM/dd/yyyy");
                        SizeF textSize = g.MeasureString(text, font);
                        float x = width - width / 30 - textSize.Width;
                        float y = height - height / 30 - textSize.Height;

                        g.DrawString(text, font, Brushes.Pink, new PointF(x, y));
                    }
                    bmp.Dispose();
                    string savePath = fileName;

                    if (!replaceOriginal)
                    {
                        savePath = fileName.Replace(textBoxSourceRoot.Text, textBoxDestinationRoot.Text);
                    }
                    string directory = Path.GetDirectoryName(savePath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    newBmp.Save(savePath, ImageFormat.Jpeg);
                    newBmp.Dispose();
                    System.GC.Collect();

                    count++;
                    SetPrograssbarValue(count);
                }
                catch (Exception ex)
                {
                    sb.AppendLine(fileName + "-->" + ex.Message);
                }

                if (cancalRequested)
                {
                    break;
                }
            }

            if (cancalRequested)
            {
                ShowMessageBox("User Canceled");
            }
            else
            {
                string errorMessage = sb.ToString();
                if (string.IsNullOrEmpty(errorMessage))
                {
                    ShowMessageBox("Done");
                }
                else
                {
                    ShowMessageBox("Errors occured in following files" + Environment.NewLine + errorMessage);
                }
            }
        }

        private void ShowMessageBox(string message)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(ShowMessageBox), new object[] { message });
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void SetPrograssbarValue(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.BeginInvoke(new Action<int>(SetPrograssbarValue), new object[] { value });
            }
            else
            {
                progressBar1.Value = value;
            }
        }
       
    }
}
