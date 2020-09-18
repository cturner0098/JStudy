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
    public partial class frmWaniKani : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        List<Subject> subjectList;
        int incorrectMeaning = 0;
        int incorrectReading = 0;

        bool isHidden = false;
        public frmWaniKani()
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
            RefreshForm();
        }

        private void RefreshForm()
        {
            this.Refresh();
            if (!Properties.Settings.Default.WKSettings)
            {
                frmWKSettings wkSettings = new frmWKSettings();
                this.Hide();
                wkSettings.ShowDialog();
                Properties.Settings.Default.WKSettings = true;
                Properties.Settings.Default.Save();
            }

            lblReviews.Text = Assignment.GetAvailableAssignmentCount().ToString();

            subjectList = Subject.BuildSubjectList(Assignment.GetAvailableAssignments());

            LoadNextSubject();
        }
        public void LoadNextSubject()
        {
            int reviews = Convert.ToInt32(lblReviews.Text);
            lblReviews.Text = (--reviews).ToString();

            subjectList.RemoveAt(0);
            
            if(subjectList.Count == 0)
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
            txtMeaning.Focus();

            txtReading.Enabled = subjectList[0].Readings == null ? false : true;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check based on meaning
            bool correct = false;
            var levenshtein = new Levenshtein();
            foreach(string meaning in subjectList[0].Meanings)
            {
                int lev = levenshtein.iLD(txtMeaning.Text.ToUpperInvariant(), meaning.ToUpperInvariant());
                if (lev <= 30)
                {
                    correct = true;
                    break;
                } else
                {
                    correct = false;
                }
            }

            if (!correct)
                incorrectMeaning++;

            // Check based on reading
            KanaTools kt = new KanaTools();
            txtReading.Text = kt.ToHiragana(txtReading.Text.ToLower());
            if (subjectList[0].Readings != null)
            {
                foreach (string reading in subjectList[0].Readings)
                {
                    if (kt.ToHiragana(txtReading.Text.ToLower()) == reading.ToLower())
                    {
                        correct = true;
                        break;
                    }
                    else
                    {
                        correct = false;
                    }
                }
            }
            
            if (!correct)
                incorrectReading++;

            if (incorrectMeaning == 0 && incorrectReading == 0)
            {
                await Review.CreateReview(subjectList[0].Id, incorrectMeaning, incorrectReading);
                LoadNextSubject();
            } else
            {
                btnShowAnswer.Enabled = true;
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            txtMeaning.Text = subjectList[0].Meanings[0];
            txtReading.Text = subjectList[0].Readings != null ? subjectList[0].Readings[0] : "";
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
            frmWKSettings wkSettings = new frmWKSettings();
            this.Hide();
            wkSettings.ShowDialog();
            Properties.Settings.Default.WKSettings = true;
            Properties.Settings.Default.Save();
            RefreshForm();
            this.Show();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmWKLookup wkLookup = new frmWKLookup();
            this.Hide();
            wkLookup.ShowDialog();
        }
    }
}
