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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxSourceRoot = new System.Windows.Forms.TextBox();
            this.buttonBrowseSourceRoot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowseDestRoot = new System.Windows.Forms.Button();
            this.textBoxDestinationRoot = new System.Windows.Forms.TextBox();
            this.checkBoxReplaceOriginal = new System.Windows.Forms.CheckBox();
            this.checkBoxAddCreatedDate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewImageWidth = new System.Windows.Forms.TextBox();
            this.textBoxNewImageHeight = new System.Windows.Forms.TextBox();
            this.radioButtonSetWidth = new System.Windows.Forms.RadioButton();
            this.radioButtonSetHeight = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQT = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelQuality = new System.Windows.Forms.Label();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelReadMore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Location = new System.Drawing.Point(368, 339);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(87, 27);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxSourceRoot
            // 
            this.textBoxSourceRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSourceRoot.Location = new System.Drawing.Point(152, 6);
            this.textBoxSourceRoot.Name = "textBoxSourceRoot";
            this.textBoxSourceRoot.Size = new System.Drawing.Size(206, 23);
            this.textBoxSourceRoot.TabIndex = 1;
            // 
            // buttonBrowseSourceRoot
            // 
            this.buttonBrowseSourceRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseSourceRoot.Location = new System.Drawing.Point(365, 5);
            this.buttonBrowseSourceRoot.Name = "buttonBrowseSourceRoot";
            this.buttonBrowseSourceRoot.Size = new System.Drawing.Size(87, 27);
            this.buttonBrowseSourceRoot.TabIndex = 0;
            this.buttonBrowseSourceRoot.Text = "Browse";
            this.buttonBrowseSourceRoot.UseVisualStyleBackColor = true;
            this.buttonBrowseSourceRoot.Click += new System.EventHandler(this.buttonBrowseSourceRoot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Root Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Root Folder";
            // 
            // buttonBrowseDestRoot
            // 
            this.buttonBrowseDestRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseDestRoot.Location = new System.Drawing.Point(365, 68);
            this.buttonBrowseDestRoot.Name = "buttonBrowseDestRoot";
            this.buttonBrowseDestRoot.Size = new System.Drawing.Size(87, 27);
            this.buttonBrowseDestRoot.TabIndex = 1;
            this.buttonBrowseDestRoot.Text = "Browse";
            this.buttonBrowseDestRoot.UseVisualStyleBackColor = true;
            this.buttonBrowseDestRoot.Click += new System.EventHandler(this.buttonBrowseDestRoot_Click);
            // 
            // textBoxDestinationRoot
            // 
            this.textBoxDestinationRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDestinationRoot.Location = new System.Drawing.Point(152, 70);
            this.textBoxDestinationRoot.Name = "textBoxDestinationRoot";
            this.textBoxDestinationRoot.Size = new System.Drawing.Size(206, 23);
            this.textBoxDestinationRoot.TabIndex = 4;
            // 
            // checkBoxReplaceOriginal
            // 
            this.checkBoxReplaceOriginal.AutoSize = true;
            this.checkBoxReplaceOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxReplaceOriginal.Location = new System.Drawing.Point(10, 38);
            this.checkBoxReplaceOriginal.Name = "checkBoxReplaceOriginal";
            this.checkBoxReplaceOriginal.Size = new System.Drawing.Size(160, 19);
            this.checkBoxReplaceOriginal.TabIndex = 4;
            this.checkBoxReplaceOriginal.Text = "Replace Original Image";
            this.checkBoxReplaceOriginal.UseVisualStyleBackColor = true;
            this.checkBoxReplaceOriginal.CheckedChanged += new System.EventHandler(this.checkBoxReplaceOriginal_CheckedChanged);
            // 
            // checkBoxAddCreatedDate
            // 
            this.checkBoxAddCreatedDate.AutoSize = true;
            this.checkBoxAddCreatedDate.Checked = true;
            this.checkBoxAddCreatedDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddCreatedDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAddCreatedDate.Location = new System.Drawing.Point(30, 251);
            this.checkBoxAddCreatedDate.Name = "checkBoxAddCreatedDate";
            this.checkBoxAddCreatedDate.Size = new System.Drawing.Size(248, 19);
            this.checkBoxAddCreatedDate.TabIndex = 9;
            this.checkBoxAddCreatedDate.Text = "Add Date Label in Lower Right Corner ";
            this.checkBoxAddCreatedDate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Image Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Image Height";
            // 
            // textBoxNewImageWidth
            // 
            this.textBoxNewImageWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewImageWidth.Location = new System.Drawing.Point(176, 78);
            this.textBoxNewImageWidth.Name = "textBoxNewImageWidth";
            this.textBoxNewImageWidth.Size = new System.Drawing.Size(120, 23);
            this.textBoxNewImageWidth.TabIndex = 2;
            this.textBoxNewImageWidth.Text = "2000";
            this.textBoxNewImageWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewImageWidth_KeyPress);
            // 
            // textBoxNewImageHeight
            // 
            this.textBoxNewImageHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewImageHeight.Enabled = false;
            this.textBoxNewImageHeight.Location = new System.Drawing.Point(176, 106);
            this.textBoxNewImageHeight.Name = "textBoxNewImageHeight";
            this.textBoxNewImageHeight.Size = new System.Drawing.Size(120, 23);
            this.textBoxNewImageHeight.TabIndex = 13;
            this.textBoxNewImageHeight.Text = "800";
            this.textBoxNewImageHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewImageHeight_KeyPress);
            // 
            // radioButtonSetWidth
            // 
            this.radioButtonSetWidth.AutoSize = true;
            this.radioButtonSetWidth.Checked = true;
            this.radioButtonSetWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSetWidth.Location = new System.Drawing.Point(25, 25);
            this.radioButtonSetWidth.Name = "radioButtonSetWidth";
            this.radioButtonSetWidth.Size = new System.Drawing.Size(271, 19);
            this.radioButtonSetWidth.TabIndex = 3;
            this.radioButtonSetWidth.TabStop = true;
            this.radioButtonSetWidth.Text = "Set Given Width and Auto Calculate Height";
            this.radioButtonSetWidth.UseVisualStyleBackColor = true;
            this.radioButtonSetWidth.CheckedChanged += new System.EventHandler(this.radioButtonSetWidth_CheckedChanged);
            // 
            // radioButtonSetHeight
            // 
            this.radioButtonSetHeight.AutoSize = true;
            this.radioButtonSetHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSetHeight.Location = new System.Drawing.Point(25, 50);
            this.radioButtonSetHeight.Name = "radioButtonSetHeight";
            this.radioButtonSetHeight.Size = new System.Drawing.Size(271, 19);
            this.radioButtonSetHeight.TabIndex = 15;
            this.radioButtonSetHeight.Text = "Set Given Height and Auto Calculate Width";
            this.radioButtonSetHeight.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(13, 348);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(345, 16);
            this.progressBar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(260, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Created By :";
            // 
            // labelQT
            // 
            this.labelQT.AutoSize = true;
            this.labelQT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQT.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQT.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelQT.Location = new System.Drawing.Point(325, 372);
            this.labelQT.Name = "labelQT";
            this.labelQT.Size = new System.Drawing.Size(132, 14);
            this.labelQT.TabIndex = 18;
            this.labelQT.Text = "Quantine Technologies ";
            this.labelQT.Click += new System.EventHandler(this.labelQT_Click);
            this.labelQT.MouseEnter += new System.EventHandler(this.labelQT_MouseEnter);
            this.labelQT.MouseLeave += new System.EventHandler(this.labelQT_MouseLeave);
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.groupBox2);
            this.panelControls.Controls.Add(this.groupBox1);
            this.panelControls.Controls.Add(this.checkBoxAddCreatedDate);
            this.panelControls.Controls.Add(this.checkBoxReplaceOriginal);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.buttonBrowseDestRoot);
            this.panelControls.Controls.Add(this.textBoxDestinationRoot);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.buttonBrowseSourceRoot);
            this.panelControls.Controls.Add(this.textBoxSourceRoot);
            this.panelControls.Location = new System.Drawing.Point(5, 52);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(452, 273);
            this.panelControls.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelQuality);
            this.groupBox2.Controls.Add(this.trackBarQuality);
            this.groupBox2.Location = new System.Drawing.Point(365, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(84, 145);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quailty";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.BackColor = System.Drawing.Color.White;
            this.labelQuality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuality.Location = new System.Drawing.Point(26, 117);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(34, 17);
            this.labelQuality.TabIndex = 19;
            this.labelQuality.Text = "75%";
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Location = new System.Drawing.Point(28, 15);
            this.trackBarQuality.Maximum = 100;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarQuality.Size = new System.Drawing.Size(45, 105);
            this.trackBarQuality.SmallChange = 5;
            this.trackBarQuality.TabIndex = 17;
            this.trackBarQuality.TickFrequency = 5;
            this.trackBarQuality.Value = 75;
            this.trackBarQuality.Scroll += new System.EventHandler(this.trackBarQuality_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSetHeight);
            this.groupBox1.Controls.Add(this.radioButtonSetWidth);
            this.groupBox1.Controls.Add(this.textBoxNewImageHeight);
            this.groupBox1.Controls.Add(this.textBoxNewImageWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 145);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Image Size";
            // 
            // labelReadMore
            // 
            this.labelReadMore.AutoSize = true;
            this.labelReadMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReadMore.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadMore.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelReadMore.Location = new System.Drawing.Point(87, 38);
            this.labelReadMore.Name = "labelReadMore";
            this.labelReadMore.Size = new System.Drawing.Size(64, 14);
            this.labelReadMore.TabIndex = 21;
            this.labelReadMore.Text = "Read More";
            this.labelReadMore.Click += new System.EventHandler(this.labelReadMore_Click);
            this.labelReadMore.MouseEnter += new System.EventHandler(this.labelReadMore_MouseEnter);
            this.labelReadMore.MouseLeave += new System.EventHandler(this.labelReadMore_MouseLeave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(2, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 48);
            this.label7.TabIndex = 20;
            this.label7.Text = "Note: \r\nThis Software converts all the jpg images in the Image Root Folder to the" +
    " specified size and quality.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(467, 386);
            this.Controls.Add(this.labelReadMore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.labelQT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonRun);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Image Size Reducer";
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxAddCreatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewImageWidth;
        private System.Windows.Forms.TextBox textBoxNewImageHeight;
        private System.Windows.Forms.RadioButton radioButtonSetWidth;
        private System.Windows.Forms.RadioButton radioButtonSetHeight;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQT;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelReadMore;
        private System.Windows.Forms.Label label7;
    }
}

