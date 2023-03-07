using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JStudy.WaniKani
{
    public partial class WaniKaniLesson : WaniKaniBase
    {
        public WaniKaniLesson()
        {
            InitializeComponent();
        }

        private void frmWKLesson_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.WKSettings)
            {
                WaniKaniSetting wkSettings = new WaniKaniSetting();
                this.Hide();
                wkSettings.ShowDialog();
                Properties.Settings.Default.WKSettings = true;
                Properties.Settings.Default.Save();
            }

            LoadNextSubject();
        }

        private void RefreshForm()
        {
            this.Refresh();

            lblLessons.Text = Assignment.GetAvailableLessonsCount().ToString();

            subjectList = Subject.BuildSubjectList(Assignment.GetAvailableLessons());

            if (subjectList != null)
            {
                subjectList = subjectList.OrderBy(x => Guid.NewGuid().ToString()).ToList();
            }
        }

        public void LoadNextSubject()
        {
            RefreshForm();

            int reviews = Convert.ToInt32(lblLessons.Text);
            lblLessons.Text = (--reviews).ToString();

            if (subjectList == null || subjectList.Count == 0)
            {         
                lblSlug.Text = "done";
                return;
            }

            lblSlug.Text = subjectList[0].Character;
            lblSubjectType.Text = subjectList[0].Object;
            lblReading.Text = string.Join(", ", subjectList[0].Meanings);
            rtbMeaningMneumonic.Text = subjectList[0].Mneumonic;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            LoadNextSubject();
        }
    }
}
