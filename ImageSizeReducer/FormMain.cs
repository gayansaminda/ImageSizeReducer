/*
 
Copyright (c) 2017 Quantine Technologies (Pvt) Ltd. (www.quantinetech.com)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this Source Code, Binary Files, and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software.

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSizeReducer
{
    public partial class FormMain : Form
    {
        #region Private Variables

        private List<string> fileList;
        private Thread progressThread;
        private bool cancalRequested;
        private bool setWidth;
        private bool addDateLabel;
        private bool replaceOriginal;
        private bool isRunningProcess;
        private long imageQuality;
        #endregion

        #region Constructor

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region UI Event Handelers

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
            if (isRunningProcess)
            {
                cancalRequested = true;
                buttonRun.Enabled = false;
                if (progressThread != null)
                {
                    progressThread.Join();
                }
                buttonRun.Enabled = true;
            }
            else
            {
                if (!VerifyParameters())
                {
                    return;
                }              

                cancalRequested = false;
                setWidth = radioButtonSetWidth.Checked;
                addDateLabel = checkBoxAddCreatedDate.Checked;
                replaceOriginal = checkBoxReplaceOriginal.Checked;
                imageQuality = trackBarQuality.Value;

                string[] dirs = Directory.GetDirectories(textBoxSourceRoot.Text, "*", SearchOption.AllDirectories);
                List<string> dirList = new List<string>(dirs);
                dirList.Insert(0, textBoxSourceRoot.Text);

                fileList = new List<string>();

                foreach (string str in dirList)
                {
                    string[] Files = Directory.GetFiles(str, "*.jpg");
                    fileList.AddRange(Files);
                }
                progressBar.Maximum = fileList.Count;

                progressThread = new Thread(ProcessFiles);
                progressThread.Start();
            }
        }        

        private void labelQT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.quantinetech.com");
        }

        private void labelQT_MouseEnter(object sender, EventArgs e)
        {
            labelQT.Font = new Font(labelQT.Font, FontStyle.Bold);
        }

        private void labelQT_MouseLeave(object sender, EventArgs e)
        {
            labelQT.Font = new Font(labelQT.Font, FontStyle.Regular);
        }

        private void textBoxNewImageWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewImageHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButtonSetWidth_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewImageWidth.Enabled = radioButtonSetWidth.Checked;
            textBoxNewImageHeight.Enabled = radioButtonSetHeight.Checked;
        }

        #endregion

        #region Private Functions

        private void ProcessFiles()
        {
            Font font = new Font(FontFamily.GenericSerif, 25);
            int count = 0;
            StringBuilder sb = new StringBuilder();
            Regex regEx = new Regex(":");

            SetProcessRuningStatus(true);

            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            EncoderParameters encorderParams = new EncoderParameters(1);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, imageQuality);
            encorderParams.Param[0] = myEncoderParameter;
            ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");

            try
            {
                foreach (string fileName in fileList)
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(fileName);
                        float width = 0;
                        float height = 0;

                        // Setting destination image width and height accordingly 
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
                            FileInfo info = new FileInfo(fileName);
                            string text = string.Empty;

                            try
                            {
                                // Read the date from metadata
                                PropertyItem propItem = bmp.GetPropertyItem(36867);
                                string dateTaken = regEx.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                                text = (DateTime.Parse(dateTaken)).ToString("MM/dd/yyyy");
                            }
                            catch (Exception)
                            {
                                // Get the last written time as the captured date. if metadata is not awailable
                                text = info.LastWriteTime.ToString("MM/dd/yyyy");
                            }

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
                        newBmp.Save(savePath, myImageCodecInfo, encorderParams);
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
                    ShowMessageBox("User Canceled", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string errorMessage = sb.ToString();
                    if (string.IsNullOrEmpty(errorMessage))
                    {
                        ShowMessageBox("Done", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ShowMessageBox("Errors occurred in following files" + Environment.NewLine + errorMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            finally
            {
                SetProcessRuningStatus(false);
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void SetProcessRuningStatus(bool isRunning)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<bool>(SetProcessRuningStatus), new Object[] { isRunning });
            }
            else
            {
                panelControls.Enabled = !isRunning;
                isRunningProcess = isRunning;
                if (isRunning)
                {
                    buttonRun.Text = "Stop";
                }
                else
                {
                    buttonRun.Text = "Run";
                }
            }
        }

        private void ShowMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, string, MessageBoxButtons, MessageBoxIcon>(ShowMessageBox), new object[] { message, caption, buttons, icon });
            }
            else
            {
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        private void SetPrograssbarValue(int value)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.BeginInvoke(new Action<int>(SetPrograssbarValue), new object[] { value });
            }
            else
            {
                progressBar.Value = value;
            }
        }

        private bool VerifyParameters()
        {
            if (string.IsNullOrEmpty(textBoxSourceRoot.Text.Trim()))
            {
                MessageBox.Show("Image root folder should not be empty", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (!(checkBoxReplaceOriginal.Checked) && (string.IsNullOrEmpty(textBoxDestinationRoot.Text.Trim())))
            {
                MessageBox.Show("Destination root folder should not be empty", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            int width = 0;
            int height = 0;
            int.TryParse(textBoxNewImageWidth.Text,out width);
            int.TryParse(textBoxNewImageHeight.Text,out height);

            if(((radioButtonSetWidth.Checked) && (width==0) )||((radioButtonSetHeight.Checked) && (height==0) ))
            {
                MessageBox.Show("New image size is invalid", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion       

        private void trackBarQuality_Scroll(object sender, EventArgs e)
        {
            labelQuality.Text = trackBarQuality.Value.ToString() + "%";
        }
       
    }
}
