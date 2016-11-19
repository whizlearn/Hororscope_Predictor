namespace Assignment4
{
    partial class _frmHoroscopePredictionEditorForm
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
            this._lblSelectASign = new System.Windows.Forms.Label();
            this._cmbSign = new System.Windows.Forms.ComboBox();
            this._ptbSign = new System.Windows.Forms.PictureBox();
            this._lblEnterPrediction = new System.Windows.Forms.Label();
            this._rtbEnterPrediction = new System.Windows.Forms.RichTextBox();
            this._btnAddPrediction = new System.Windows.Forms.Button();
            this._lblPredictionList = new System.Windows.Forms.Label();
            this._lstPredictionList = new System.Windows.Forms.ListBox();
            this._btnLoad = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ptbSign)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblSelectASign
            // 
            this._lblSelectASign.AutoSize = true;
            this._lblSelectASign.Location = new System.Drawing.Point(34, 33);
            this._lblSelectASign.Name = "_lblSelectASign";
            this._lblSelectASign.Size = new System.Drawing.Size(74, 13);
            this._lblSelectASign.TabIndex = 0;
            this._lblSelectASign.Text = "Select a sign: ";
            // 
            // _cmbSign
            // 
            this._cmbSign.FormattingEnabled = true;
            this._cmbSign.Location = new System.Drawing.Point(126, 33);
            this._cmbSign.Name = "_cmbSign";
            this._cmbSign.Size = new System.Drawing.Size(307, 21);
            this._cmbSign.TabIndex = 1;
            this._cmbSign.SelectedIndexChanged += new System.EventHandler(this._cmbSign_SelectedIndexChanged);
            // 
            // _ptbSign
            // 
            this._ptbSign.Location = new System.Drawing.Point(496, 33);
            this._ptbSign.Name = "_ptbSign";
            this._ptbSign.Size = new System.Drawing.Size(175, 246);
            this._ptbSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._ptbSign.TabIndex = 2;
            this._ptbSign.TabStop = false;
            // 
            // _lblEnterPrediction
            // 
            this._lblEnterPrediction.AutoSize = true;
            this._lblEnterPrediction.Location = new System.Drawing.Point(34, 95);
            this._lblEnterPrediction.Name = "_lblEnterPrediction";
            this._lblEnterPrediction.Size = new System.Drawing.Size(164, 13);
            this._lblEnterPrediction.TabIndex = 3;
            this._lblEnterPrediction.Text = "Enter prediction for selected sign:";
            // 
            // _rtbEnterPrediction
            // 
            this._rtbEnterPrediction.Location = new System.Drawing.Point(37, 123);
            this._rtbEnterPrediction.Name = "_rtbEnterPrediction";
            this._rtbEnterPrediction.Size = new System.Drawing.Size(439, 112);
            this._rtbEnterPrediction.TabIndex = 4;
            this._rtbEnterPrediction.Text = "";
            // 
            // _btnAddPrediction
            // 
            this._btnAddPrediction.Location = new System.Drawing.Point(360, 256);
            this._btnAddPrediction.Name = "_btnAddPrediction";
            this._btnAddPrediction.Size = new System.Drawing.Size(116, 23);
            this._btnAddPrediction.TabIndex = 5;
            this._btnAddPrediction.Text = "Add Prediction";
            this._btnAddPrediction.UseVisualStyleBackColor = true;
            this._btnAddPrediction.Click += new System.EventHandler(this._btnAddPrediction_Click);
            // 
            // _lblPredictionList
            // 
            this._lblPredictionList.AutoSize = true;
            this._lblPredictionList.Location = new System.Drawing.Point(34, 298);
            this._lblPredictionList.Name = "_lblPredictionList";
            this._lblPredictionList.Size = new System.Drawing.Size(73, 13);
            this._lblPredictionList.TabIndex = 6;
            this._lblPredictionList.Text = "Prediction List";
            // 
            // _lstPredictionList
            // 
            this._lstPredictionList.FormattingEnabled = true;
            this._lstPredictionList.Location = new System.Drawing.Point(37, 319);
            this._lstPredictionList.Name = "_lstPredictionList";
            this._lstPredictionList.Size = new System.Drawing.Size(634, 147);
            this._lstPredictionList.TabIndex = 7;
            // 
            // _btnLoad
            // 
            this._btnLoad.Location = new System.Drawing.Point(37, 498);
            this._btnLoad.Name = "_btnLoad";
            this._btnLoad.Size = new System.Drawing.Size(116, 23);
            this._btnLoad.TabIndex = 8;
            this._btnLoad.Text = "Load";
            this._btnLoad.UseVisualStyleBackColor = true;
            this._btnLoad.Click += new System.EventHandler(this._btnLoad_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(170, 498);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(116, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(555, 498);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(116, 23);
            this._btnClose.TabIndex = 10;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _frmHoroscopePredictionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 559);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnLoad);
            this.Controls.Add(this._lstPredictionList);
            this.Controls.Add(this._lblPredictionList);
            this.Controls.Add(this._btnAddPrediction);
            this.Controls.Add(this._rtbEnterPrediction);
            this.Controls.Add(this._lblEnterPrediction);
            this.Controls.Add(this._ptbSign);
            this.Controls.Add(this._cmbSign);
            this.Controls.Add(this._lblSelectASign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "_frmHoroscopePredictionEditorForm";
            this.Text = "Horoscope Predictor Database Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._frmHoroscopePredictionEditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._ptbSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblSelectASign;
        private System.Windows.Forms.ComboBox _cmbSign;
        private System.Windows.Forms.PictureBox _ptbSign;
        private System.Windows.Forms.Label _lblEnterPrediction;
        private System.Windows.Forms.RichTextBox _rtbEnterPrediction;
        private System.Windows.Forms.Button _btnAddPrediction;
        private System.Windows.Forms.Label _lblPredictionList;
        private System.Windows.Forms.ListBox _lstPredictionList;
        private System.Windows.Forms.Button _btnLoad;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnClose;
    }
}