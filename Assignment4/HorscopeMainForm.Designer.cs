namespace Assignment4
{
    partial class _frmHorscopeMainForm
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
            this._mnuStrip = new System.Windows.Forms.MenuStrip();
            this._mnuZodiac = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItmEditUserProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._mnuItmClose = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItmPredictionEditor = new System.Windows.Forms.ToolStripMenuItem();
            this._ptbUserPhoto = new System.Windows.Forms.PictureBox();
            this._lblName = new System.Windows.Forms.Label();
            this._lblBirthday = new System.Windows.Forms.Label();
            this._lblZodiac = new System.Windows.Forms.Label();
            this._lblNameOutput = new System.Windows.Forms.Label();
            this._lblBirthdayOutput = new System.Windows.Forms.Label();
            this._lblZodiacOutput = new System.Windows.Forms.Label();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnUpdateDailyHoroscope = new System.Windows.Forms.Button();
            this._btnEditProfile = new System.Windows.Forms.Button();
            this._grpHoroscope = new System.Windows.Forms.GroupBox();
            this._rtbPrediction = new System.Windows.Forms.RichTextBox();
            this._mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ptbUserPhoto)).BeginInit();
            this._grpHoroscope.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mnuStrip
            // 
            this._mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuZodiac,
            this._mnuAdmin});
            this._mnuStrip.Location = new System.Drawing.Point(0, 0);
            this._mnuStrip.Name = "_mnuStrip";
            this._mnuStrip.Size = new System.Drawing.Size(641, 24);
            this._mnuStrip.TabIndex = 0;
            this._mnuStrip.Text = "menuStrip1";
            // 
            // _mnuZodiac
            // 
            this._mnuZodiac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuItmEditUserProfile,
            this.toolStripSeparator1,
            this._mnuItmClose});
            this._mnuZodiac.Name = "_mnuZodiac";
            this._mnuZodiac.Size = new System.Drawing.Size(55, 20);
            this._mnuZodiac.Text = "Zodiac";
            // 
            // _mnuItmEditUserProfile
            // 
            this._mnuItmEditUserProfile.Name = "_mnuItmEditUserProfile";
            this._mnuItmEditUserProfile.Size = new System.Drawing.Size(166, 22);
            this._mnuItmEditUserProfile.Text = "Edit User Profile...";
            this._mnuItmEditUserProfile.Click += new System.EventHandler(this._mnuItmEditUserProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // _mnuItmClose
            // 
            this._mnuItmClose.Name = "_mnuItmClose";
            this._mnuItmClose.Size = new System.Drawing.Size(166, 22);
            this._mnuItmClose.Text = "Close";
            this._mnuItmClose.Click += new System.EventHandler(this._mnuItmClose_Click);
            // 
            // _mnuAdmin
            // 
            this._mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuItmPredictionEditor});
            this._mnuAdmin.Name = "_mnuAdmin";
            this._mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this._mnuAdmin.Text = "Admin";
            // 
            // _mnuItmPredictionEditor
            // 
            this._mnuItmPredictionEditor.Name = "_mnuItmPredictionEditor";
            this._mnuItmPredictionEditor.Size = new System.Drawing.Size(171, 22);
            this._mnuItmPredictionEditor.Text = "Prediction Editor...";
            this._mnuItmPredictionEditor.Click += new System.EventHandler(this._mnuItmPredictionEditor_Click);
            // 
            // _ptbUserPhoto
            // 
            this._ptbUserPhoto.Location = new System.Drawing.Point(400, 44);
            this._ptbUserPhoto.Name = "_ptbUserPhoto";
            this._ptbUserPhoto.Size = new System.Drawing.Size(216, 245);
            this._ptbUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._ptbUserPhoto.TabIndex = 1;
            this._ptbUserPhoto.TabStop = false;
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(399, 323);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(38, 13);
            this._lblName.TabIndex = 2;
            this._lblName.Text = "Name:";
            // 
            // _lblBirthday
            // 
            this._lblBirthday.AutoSize = true;
            this._lblBirthday.Location = new System.Drawing.Point(397, 353);
            this._lblBirthday.Name = "_lblBirthday";
            this._lblBirthday.Size = new System.Drawing.Size(48, 13);
            this._lblBirthday.TabIndex = 3;
            this._lblBirthday.Text = "Birthday:";
            // 
            // _lblZodiac
            // 
            this._lblZodiac.AutoSize = true;
            this._lblZodiac.Location = new System.Drawing.Point(397, 383);
            this._lblZodiac.Name = "_lblZodiac";
            this._lblZodiac.Size = new System.Drawing.Size(43, 13);
            this._lblZodiac.TabIndex = 4;
            this._lblZodiac.Text = "Zodiac:";
            // 
            // _lblNameOutput
            // 
            this._lblNameOutput.AutoSize = true;
            this._lblNameOutput.Location = new System.Drawing.Point(494, 323);
            this._lblNameOutput.Name = "_lblNameOutput";
            this._lblNameOutput.Size = new System.Drawing.Size(35, 13);
            this._lblNameOutput.TabIndex = 5;
            this._lblNameOutput.Text = "label4";
            // 
            // _lblBirthdayOutput
            // 
            this._lblBirthdayOutput.AutoSize = true;
            this._lblBirthdayOutput.Location = new System.Drawing.Point(494, 353);
            this._lblBirthdayOutput.Name = "_lblBirthdayOutput";
            this._lblBirthdayOutput.Size = new System.Drawing.Size(35, 13);
            this._lblBirthdayOutput.TabIndex = 6;
            this._lblBirthdayOutput.Text = "label5";
            // 
            // _lblZodiacOutput
            // 
            this._lblZodiacOutput.AutoSize = true;
            this._lblZodiacOutput.Location = new System.Drawing.Point(494, 383);
            this._lblZodiacOutput.Name = "_lblZodiacOutput";
            this._lblZodiacOutput.Size = new System.Drawing.Size(35, 13);
            this._lblZodiacOutput.TabIndex = 7;
            this._lblZodiacOutput.Text = "label6";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(24, 452);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 9;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _btnUpdateDailyHoroscope
            // 
            this._btnUpdateDailyHoroscope.Location = new System.Drawing.Point(199, 452);
            this._btnUpdateDailyHoroscope.Name = "_btnUpdateDailyHoroscope";
            this._btnUpdateDailyHoroscope.Size = new System.Drawing.Size(174, 23);
            this._btnUpdateDailyHoroscope.TabIndex = 10;
            this._btnUpdateDailyHoroscope.Text = "Update Daily Horoscope";
            this._btnUpdateDailyHoroscope.UseVisualStyleBackColor = true;
            this._btnUpdateDailyHoroscope.Click += new System.EventHandler(this._btnUpdateDailyHoroscope_Click);
            // 
            // _btnEditProfile
            // 
            this._btnEditProfile.Location = new System.Drawing.Point(521, 452);
            this._btnEditProfile.Name = "_btnEditProfile";
            this._btnEditProfile.Size = new System.Drawing.Size(95, 23);
            this._btnEditProfile.TabIndex = 11;
            this._btnEditProfile.Text = "Edit Profile...";
            this._btnEditProfile.UseVisualStyleBackColor = true;
            this._btnEditProfile.Click += new System.EventHandler(this._btnEditProfile_Click);
            // 
            // _grpHoroscope
            // 
            this._grpHoroscope.Controls.Add(this._rtbPrediction);
            this._grpHoroscope.Location = new System.Drawing.Point(24, 44);
            this._grpHoroscope.Name = "_grpHoroscope";
            this._grpHoroscope.Size = new System.Drawing.Size(349, 360);
            this._grpHoroscope.TabIndex = 12;
            this._grpHoroscope.TabStop = false;
            this._grpHoroscope.Text = "Today\'s Horoscope";
            // 
            // _rtbPrediction
            // 
            this._rtbPrediction.Location = new System.Drawing.Point(3, 16);
            this._rtbPrediction.Name = "_rtbPrediction";
            this._rtbPrediction.Size = new System.Drawing.Size(340, 336);
            this._rtbPrediction.TabIndex = 0;
            this._rtbPrediction.Text = "";
            // 
            // _frmHorscopeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 496);
            this.Controls.Add(this._grpHoroscope);
            this.Controls.Add(this._btnEditProfile);
            this.Controls.Add(this._btnUpdateDailyHoroscope);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._lblZodiacOutput);
            this.Controls.Add(this._lblBirthdayOutput);
            this.Controls.Add(this._lblNameOutput);
            this.Controls.Add(this._lblZodiac);
            this.Controls.Add(this._lblBirthday);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this._ptbUserPhoto);
            this.Controls.Add(this._mnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this._mnuStrip;
            this.Name = "_frmHorscopeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horscope 1.0";
            this.Activated += new System.EventHandler(this._frmHorscopeMainForm_Activated);
            this._mnuStrip.ResumeLayout(false);
            this._mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ptbUserPhoto)).EndInit();
            this._grpHoroscope.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem _mnuZodiac;
        private System.Windows.Forms.ToolStripMenuItem _mnuAdmin;
        private System.Windows.Forms.PictureBox _ptbUserPhoto;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblBirthday;
        private System.Windows.Forms.Label _lblZodiac;
        private System.Windows.Forms.Label _lblNameOutput;
        private System.Windows.Forms.Label _lblBirthdayOutput;
        private System.Windows.Forms.Label _lblZodiacOutput;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnUpdateDailyHoroscope;
        private System.Windows.Forms.Button _btnEditProfile;
        private System.Windows.Forms.GroupBox _grpHoroscope;
        private System.Windows.Forms.ToolStripMenuItem _mnuItmEditUserProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _mnuItmClose;
        private System.Windows.Forms.ToolStripMenuItem _mnuItmPredictionEditor;
        private System.Windows.Forms.RichTextBox _rtbPrediction;
    }
}

