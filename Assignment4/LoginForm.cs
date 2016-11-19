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
    public partial class _frmAdministratorLogin : Form

    {
        /// <summary>
        /// This variable controls state of the HoroscopePredictionEditor: true is open, false is closed
        /// </summary>
        public static bool s_isHoroscopePredictionEditorFormOpen = false;
        _frmHoroscopePredictionEditorForm predictionEditor;

        public _frmAdministratorLogin()
        {
            InitializeComponent();
           
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            
            if(_txtUserName.Text == Settings.Default.Username && _txtPassword.Text == Settings.Default.Password)
            {
                if (!s_isHoroscopePredictionEditorFormOpen)
                {
                    _frmAdministratorLogin.ActiveForm.Close();
                    predictionEditor = new _frmHoroscopePredictionEditorForm();
                    predictionEditor.Show();
                    s_isHoroscopePredictionEditorFormOpen = true;
                    
                }
                else
                {
                    predictionEditor.Focus();
                    
                }
                               
            }
            else
            {
                MessageBox.Show("The username and password you entered do not match, please try again");
            }
        }

        /// <summary>
        /// When Cancel button is clicked, the login form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            _frmAdministratorLogin.ActiveForm.Close();
        }

       
    }
}
