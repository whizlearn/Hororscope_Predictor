using Assignment4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class _frmUserAccount : Form
    {
        public _frmUserAccount()
        {
            InitializeComponent();
        }

        private void _btnChoosePicture_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                _txtAvatar.Text = openFileDialog1.FileName;
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.NameOfUser = _txtName.Text;
            Settings.Default.Birthday = _dtpBirthday.Value.Date;
            Settings.Default.Avatar = _txtAvatar.Text;

            Settings.Default.Save();
            Close();
        }

        private void _frmUserAccount_Activated(object sender, EventArgs e)
        {
            if (Settings.Default.Birthday != null)
            {
                _txtName.Text = Settings.Default.NameOfUser;
                _dtpBirthday.Value = Settings.Default.Birthday;
                _txtAvatar.Text = Settings.Default.Avatar;
            }
        }
    }
}
