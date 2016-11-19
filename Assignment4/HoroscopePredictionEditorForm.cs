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
    public partial class _frmHoroscopePredictionEditorForm : Form
    {
        private ZodiacSign _currentZodiagSign;
        private Horoscope _horoscope;

        public _frmHoroscopePredictionEditorForm()
        {
            InitializeComponent();
            _horoscope = Horoscope.GetInstance();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _cmbSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentZodiagSign = _cmbSign.SelectedItem as ZodiacSign;
            if(_currentZodiagSign != null)
            {
                _ptbSign.Image = Image.FromFile(_currentZodiagSign.ImagePath);
                DisplayPredictions();
            }
        }

        private void _frmHoroscopePredictionEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmAdministratorLogin.s_isHoroscopePredictionEditorFormOpen = false;
        }

        private void _btnAddPrediction_Click(object sender, EventArgs e)
        {
            if (_currentZodiagSign == null) {
                return;
            }

            if (_rtbEnterPrediction.Text == "") {
                MessageBox.Show("Enter prediction!");
                _rtbEnterPrediction.Focus();
            }

            // add prediction to the current zodiac
            _currentZodiagSign.PredictionList.AddPrediction(_rtbEnterPrediction.Text);
            
            _rtbEnterPrediction.Text = "";
            DisplayPredictions();   
        }


        /// <summary>
        /// This is a convenient method to display predictions of the currently selected zodiac in the list box
        /// </summary>
        private void DisplayPredictions() 
        {
            _lstPredictionList.Items.Clear();
            foreach (string prediction in _currentZodiagSign.PredictionList)
            {
                _lstPredictionList.Items.Add(prediction);
            }
        }
        
        private void _btnLoad_Click(object sender, EventArgs e)
        {
            _cmbSign.Items.Clear();

            List<ZodiacSign> zodiacSignList = null;

            try
            {
                zodiacSignList = _horoscope.LoadData();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load data error!");
                return;
            }

            foreach (ZodiacSign zs in zodiacSignList)
            {
                _cmbSign.Items.Add(zs);
            }
            _cmbSign.SelectedIndex = 0;
            _cmbSign.Focus();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            List<ZodiacSign> zodiacSignList = new List<ZodiacSign>();

            // copy items from combobox to List<ZodiacInfo>
            foreach(Object zodiac in _cmbSign.Items)
            {
                zodiacSignList.Add(zodiac as ZodiacSign);
            }
            
            // set new list of ZodiacInfo so it can be saved
            _horoscope.SetZodiacList(zodiacSignList);
            
            try
            {
                _horoscope.SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save data error!");
                return;
            }
            MessageBox.Show("All data has been saved.");
        }
    }
}
