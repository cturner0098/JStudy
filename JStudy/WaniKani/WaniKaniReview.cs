using JStudy.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JStudy.WaniKani
{
    public partial class WaniKaniReview : WaniKaniBase
    {
        int incorrectMeaning, incorrectReading;
        bool isHidden = false;
        bool isFailed = false;
        public WaniKaniReview()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 4, 0, (int)Keys.F10);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                if(isHidden)
                {
                    this.Visible = true;
                    isHidden = false;
                } else
                {
                    this.Visible = false;
                    isHidden = true;
                }
                
            }
        }

        private void frmWaniKani_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.APIKey == default || Properties.Settings.Default.StudyTypes == default)
            {
                WaniKaniSetting wkSettings = new WaniKaniSetting();
                this.Hide();
                wkSettings.ShowDialog();
            }

            LoadNextSubject();
        }

        private void RefreshForm()
        {
            this.Refresh();
            
            lblReviews.Text = Assignment.GetAvailableReviewCount().ToString();

            subjectList = Subject.BuildSubjectList(Assignment.GetAvailableReviews());

            if(subjectList != null) 
            { 
                subjectList = subjectList.OrderBy(x => Guid.NewGuid().ToString()).ToList();
            }
        }

        public void LoadNextSubject()
        {
            RefreshForm();

            isFailed = false;
            btnSubmit.Text = "Submit";

            int reviews = Convert.ToInt32(lblReviews.Text);
            lblReviews.Text = (--reviews).ToString();
            
            if(subjectList == null || subjectList.Count == 0)
            {
                btnSubmit.Enabled = false;
                btnShowAnswer.Enabled = false;
                lblSlug.Text = "done";
                return;
            }

            lblSlug.Text = subjectList[0].Character;
            lblSubjectType.Text = subjectList[0].Object;

            incorrectMeaning = 0;
            incorrectReading = 0;
            txtMeaning.Text = "";
            txtReading.Text = "";

            btnShowAnswer.Enabled = false;
            btnCorrect.Enabled = false;
            txtMeaning.Focus();

            if(subjectList[0].Readings == null)
            {
                txtReading.Enabled = false;
            } else
            {
                txtReading.Enabled = true;
                btnSubmit.Enabled = true;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if(isFailed)
            {
                LoadNextSubject();
                return;
            }

            // Check based on meaning
            bool correctMeaning = false, correctReading = false;
            var levenshtein = new Levenshtein();
            foreach(string meaning in subjectList[0].Meanings)
            {
                int lev = levenshtein.iLD(txtMeaning.Text.ToUpperInvariant(), meaning.ToUpperInvariant());
                if (lev <= 30)
                {
                    correctMeaning = true;
                    break;
                } else
                {
                    correctMeaning = false;
                }
            }

            if (!correctMeaning)
                incorrectMeaning++;

            // Check based on reading
            KanaTools kt = new KanaTools();
            if (subjectList[0].Readings != null)
            {
                foreach (string reading in subjectList[0].Readings)
                {
                    if (txtReading.Text.ToLower() == kt.ToRomaji(reading).ToLower())
                    {
                        correctReading = true;
                        break;
                    }
                    else
                    {
                        correctReading = false;
                    }
                }
            }
            else
            {
                correctReading = true;
            }

            if (!correctReading)
                incorrectReading++;

            if (correctMeaning && correctReading)
            {
                await Review.CreateReview(subjectList[0].Id, incorrectMeaning, incorrectReading);
                LoadNextSubject();
            } else
            {
                await Review.CreateReview(subjectList[0].Id, incorrectMeaning, incorrectReading);
                btnShowAnswer.Enabled = true;
                btnSubmit.Text = "Next";
                isFailed = true;
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            txtMeaning.Text = subjectList[0].Meanings[0];
            txtReading.Text = subjectList[0].Readings != null ? subjectList[0].Readings[0] : "";
            btnCorrect.Enabled = true;
        }

        private void txtReading_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.GetCultureInfo("ja-JP"));
        }

        private void txtMeaning_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }

        private void frmWaniKani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            WaniKaniSetting wkSettings = new WaniKaniSetting();
            this.Hide();
            wkSettings.ShowDialog();
            RefreshForm();
            this.Show();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmWKLookup wkLookup = new frmWKLookup();
            this.Hide();
            wkLookup.ShowDialog();
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            _ = Review.CreateReview(subjectList[0].Id, 0, 0);
            LoadNextSubject();
        }

        private void lblReading_Click(object sender, EventArgs e)
        {

        }

        private void txtReading_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
