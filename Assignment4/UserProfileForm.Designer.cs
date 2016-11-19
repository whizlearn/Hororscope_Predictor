namespace Assignment4
{
    partial class _frmUserAccount
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
            this._lblName = new System.Windows.Forms.Label();
            this._lblBirthday = new System.Windows.Forms.Label();
            this._lblAvatar = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this._txtAvatar = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnChoosePicture = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(59, 40);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(38, 13);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Name:";
            // 
            // _lblBirthday
            // 
            this._lblBirthday.AutoSize = true;
            this._lblBirthday.Location = new System.Drawing.Point(59, 104);
            this._lblBirthday.Name = "_lblBirthday";
            this._lblBirthday.Size = new System.Drawing.Size(48, 13);
            this._lblBirthday.TabIndex = 1;
            this._lblBirthday.Text = "Birthday:";
            // 
            // _lblAvatar
            // 
            this._lblAvatar.AutoSize = true;
            this._lblAvatar.Location = new System.Drawing.Point(59, 166);
            this._lblAvatar.Name = "_lblAvatar";
            this._lblAvatar.Size = new System.Drawing.Size(41, 13);
            this._lblAvatar.TabIndex = 2;
            this._lblAvatar.Text = "Avatar:";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(161, 40);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(360, 20);
            this._txtName.TabIndex = 3;
            // 
            // _dtpBirthday
            // 
            this._dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpBirthday.Location = new System.Drawing.Point(161, 104);
            this._dtpBirthday.Name = "_dtpBirthday";
            this._dtpBirthday.Size = new System.Drawing.Size(360, 20);
            this._dtpBirthday.TabIndex = 4;
            // 
            // _txtAvatar
            // 
            this._txtAvatar.Location = new System.Drawing.Point(161, 159);
            this._txtAvatar.Name = "_txtAvatar";
            this._txtAvatar.Size = new System.Drawing.Size(360, 20);
            this._txtAvatar.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.bmp, *.jpg) | *.bmp; *.jpg";
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(62, 225);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 6;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnChoosePicture
            // 
            this._btnChoosePicture.Location = new System.Drawing.Point(407, 185);
            this._btnChoosePicture.Name = "_btnChoosePicture";
            this._btnChoosePicture.Size = new System.Drawing.Size(114, 23);
            this._btnChoosePicture.TabIndex = 7;
            this._btnChoosePicture.Text = "Choose Picture...";
            this._btnChoosePicture.UseVisualStyleBackColor = true;
            this._btnChoosePicture.Click += new System.EventHandler(this._btnChoosePicture_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(152, 225);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 8;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _frmUserAccount
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(564, 269);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnChoosePicture);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._txtAvatar);
            this.Controls.Add(this._dtpBirthday);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._lblAvatar);
            this.Controls.Add(this._lblBirthday);
            this.Controls.Add(this._lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "_frmUserAccount";
            this.Text = "User Account";
            this.Activated += new System.EventHandler(this._frmUserAccount_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblBirthday;
        private System.Windows.Forms.Label _lblAvatar;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.DateTimePicker _dtpBirthday;
        private System.Windows.Forms.TextBox _txtAvatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnChoosePicture;
        private System.Windows.Forms.Button _btnCancel;
    }
}