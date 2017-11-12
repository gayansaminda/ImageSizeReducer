namespace ImageSizeReducer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxSourceRoot = new System.Windows.Forms.TextBox();
            this.buttonBrowseSourceRoot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowseDestRoot = new System.Windows.Forms.Button();
            this.textBoxDestinationRoot = new System.Windows.Forms.TextBox();
            this.checkBoxReplaceOriginal = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAddCreatedDate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewImageWidth = new System.Windows.Forms.TextBox();
            this.textBoxNewImageHeight = new System.Windows.Forms.TextBox();
            this.radioButtonSetWidth = new System.Windows.Forms.RadioButton();
            this.radioButtonSetHeight = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(307, 278);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxSourceRoot
            // 
            this.textBoxSourceRoot.Location = new System.Drawing.Point(124, 11);
            this.textBoxSourceRoot.Name = "textBoxSourceRoot";
            this.textBoxSourceRoot.Size = new System.Drawing.Size(177, 20);
            this.textBoxSourceRoot.TabIndex = 1;
            // 
            // buttonBrowseSourceRoot
            // 
            this.buttonBrowseSourceRoot.Location = new System.Drawing.Point(307, 11);
            this.buttonBrowseSourceRoot.Name = "buttonBrowseSourceRoot";
            this.buttonBrowseSourceRoot.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSourceRoot.TabIndex = 2;
            this.buttonBrowseSourceRoot.Text = "Browse";
            this.buttonBrowseSourceRoot.UseVisualStyleBackColor = true;
            this.buttonBrowseSourceRoot.Click += new System.EventHandler(this.buttonBrowseSourceRoot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Root Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Root Folder";
            // 
            // buttonBrowseDestRoot
            // 
            this.buttonBrowseDestRoot.Location = new System.Drawing.Point(307, 61);
            this.buttonBrowseDestRoot.Name = "buttonBrowseDestRoot";
            this.buttonBrowseDestRoot.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDestRoot.TabIndex = 5;
            this.buttonBrowseDestRoot.Text = "Browse";
            this.buttonBrowseDestRoot.UseVisualStyleBackColor = true;
            this.buttonBrowseDestRoot.Click += new System.EventHandler(this.buttonBrowseDestRoot_Click);
            // 
            // textBoxDestinationRoot
            // 
            this.textBoxDestinationRoot.Location = new System.Drawing.Point(124, 61);
            this.textBoxDestinationRoot.Name = "textBoxDestinationRoot";
            this.textBoxDestinationRoot.Size = new System.Drawing.Size(177, 20);
            this.textBoxDestinationRoot.TabIndex = 4;
            // 
            // checkBoxReplaceOriginal
            // 
            this.checkBoxReplaceOriginal.AutoSize = true;
            this.checkBoxReplaceOriginal.Location = new System.Drawing.Point(10, 37);
            this.checkBoxReplaceOriginal.Name = "checkBoxReplaceOriginal";
            this.checkBoxReplaceOriginal.Size = new System.Drawing.Size(136, 17);
            this.checkBoxReplaceOriginal.TabIndex = 7;
            this.checkBoxReplaceOriginal.Text = "Replace Original Image";
            this.checkBoxReplaceOriginal.UseVisualStyleBackColor = true;
            this.checkBoxReplaceOriginal.CheckedChanged += new System.EventHandler(this.checkBoxReplaceOriginal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Label";
            // 
            // checkBoxAddCreatedDate
            // 
            this.checkBoxAddCreatedDate.AutoSize = true;
            this.checkBoxAddCreatedDate.Checked = true;
            this.checkBoxAddCreatedDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddCreatedDate.Location = new System.Drawing.Point(13, 183);
            this.checkBoxAddCreatedDate.Name = "checkBoxAddCreatedDate";
            this.checkBoxAddCreatedDate.Size = new System.Drawing.Size(103, 17);
            this.checkBoxAddCreatedDate.TabIndex = 9;
            this.checkBoxAddCreatedDate.Text = "Add  Date Label";
            this.checkBoxAddCreatedDate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Image Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Image Height";
            // 
            // textBoxNewImageWidth
            // 
            this.textBoxNewImageWidth.Location = new System.Drawing.Point(124, 131);
            this.textBoxNewImageWidth.Name = "textBoxNewImageWidth";
            this.textBoxNewImageWidth.Size = new System.Drawing.Size(103, 20);
            this.textBoxNewImageWidth.TabIndex = 12;
            this.textBoxNewImageWidth.Text = "2000";
            // 
            // textBoxNewImageHeight
            // 
            this.textBoxNewImageHeight.Location = new System.Drawing.Point(124, 155);
            this.textBoxNewImageHeight.Name = "textBoxNewImageHeight";
            this.textBoxNewImageHeight.Size = new System.Drawing.Size(103, 20);
            this.textBoxNewImageHeight.TabIndex = 13;
            // 
            // radioButtonSetWidth
            // 
            this.radioButtonSetWidth.AutoSize = true;
            this.radioButtonSetWidth.Checked = true;
            this.radioButtonSetWidth.Location = new System.Drawing.Point(71, 89);
            this.radioButtonSetWidth.Name = "radioButtonSetWidth";
            this.radioButtonSetWidth.Size = new System.Drawing.Size(230, 17);
            this.radioButtonSetWidth.TabIndex = 14;
            this.radioButtonSetWidth.TabStop = true;
            this.radioButtonSetWidth.Text = "Set Given Width and Auto Calculate Height";
            this.radioButtonSetWidth.UseVisualStyleBackColor = true;
            // 
            // radioButtonSetHeight
            // 
            this.radioButtonSetHeight.AutoSize = true;
            this.radioButtonSetHeight.Location = new System.Drawing.Point(71, 110);
            this.radioButtonSetHeight.Name = "radioButtonSetHeight";
            this.radioButtonSetHeight.Size = new System.Drawing.Size(230, 17);
            this.radioButtonSetHeight.TabIndex = 15;
            this.radioButtonSetHeight.Text = "Set Given Height and Auto Calculate Width";
            this.radioButtonSetHeight.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(281, 14);
            this.progressBar1.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 313);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioButtonSetHeight);
            this.Controls.Add(this.radioButtonSetWidth);
            this.Controls.Add(this.textBoxNewImageHeight);
            this.Controls.Add(this.textBoxNewImageWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxAddCreatedDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxReplaceOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseDestRoot);
            this.Controls.Add(this.textBoxDestinationRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowseSourceRoot);
            this.Controls.Add(this.textBoxSourceRoot);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Image Size Reducer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxSourceRoot;
        private System.Windows.Forms.Button buttonBrowseSourceRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseDestRoot;
        private System.Windows.Forms.TextBox textBoxDestinationRoot;
        private System.Windows.Forms.CheckBox checkBoxReplaceOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAddCreatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewImageWidth;
        private System.Windows.Forms.TextBox textBoxNewImageHeight;
        private System.Windows.Forms.RadioButton radioButtonSetWidth;
        private System.Windows.Forms.RadioButton radioButtonSetHeight;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

