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
using BusinessLogicTier;

namespace Assignment4
{
    public partial class _frmHorscopeMainForm : Form
    {
        private Horoscope _horoscope;

        public _frmHorscopeMainForm()
        {
            InitializeComponent();
            _horoscope = Horoscope.GetInstance();
        }

        private void _mnuItmClose_Click(object sender, EventArgs e)
        {
            _btnClose.PerformClick();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnEditProfile_Click(object sender, EventArgs e)
        {
            _frmUserAccount userProfileForm = new _frmUserAccount();
            userProfileForm.ShowDialog();
        }

        private void _mnuItmEditUserProfile_Click(object sender, EventArgs e)
        {
            _btnEditProfile.PerformClick();
        }

        private void _btnUpdateDailyHoroscope_Click(object sender, EventArgs e)
        {
            UpdateLabelsAndPrediction();
        }

        private void UpdateLabelsAndPrediction()
        {
            //Changes today's horocope - display random prediction for the sign of the user.
            if (Settings.Default.Birthday != null)
            {
                User user = new User()
                {
                    UserName = Settings.Default.NameOfUser,
                    Birthday = Settings.Default.Birthday,
                    Avatar = Settings.Default.Avatar
                };
                _lblNameOutput.Text = user.UserName;
                _lblBirthdayOutput.Text = user.Birthday.ToShortDateString();

                ZodiacSign zodiac = _horoscope.GetZodiacSign(user);

                if (zodiac != null)
                {
                    _lblZodiacOutput.Text = zodiac.Sign;
                    _rtbPrediction.Text = zodiac.PredictionList.GetRandomPrediction();
                    
                    // display user picture or zodiac
                    if (user.Avatar != "")
                    {
                        _ptbUserPhoto.Image = Image.FromFile(user.Avatar);
                    }
                    else
                    {
                        _ptbUserPhoto.Image = Image.FromFile(zodiac.ImagePath);
                    }
                }
            }
            
        }

        private void _mnuItmDailyHoroscope_Click(object sender, EventArgs e)
        {
            _btnUpdateDailyHoroscope.PerformClick();
        }

        private void _mnuItmPredictionEditor_Click(object sender, EventArgs e)
        {
            //_frmHoroscopePredictionEditorForm predicitonEditor = new _frmHoroscopePredictionEditorForm();
            //predicitonEditor.ShowDialog(); 

            _frmAdministratorLogin adminLogin = new _frmAdministratorLogin();
            adminLogin.ShowDialog();
        }

        private void _frmHorscopeMainForm_Activated(object sender, EventArgs e)
        {
            UpdateLabelsAndPrediction();
        }
    }
}
