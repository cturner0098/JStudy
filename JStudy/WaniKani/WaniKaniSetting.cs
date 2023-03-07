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
    public partial class WaniKaniSetting : Form
    {
        public WaniKaniSetting()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<String> studyTypes = new List<string>();
            foreach (Object item in clbStudyTypes.CheckedItems)
            {
                studyTypes.Add(item.ToString().ToLower());
            }

            Properties.Settings.Default.StudyTypes = string.Join(",", studyTypes);
            Properties.Settings.Default.APIKey = txtAPIKey.Text;
            Properties.Settings.Default.Save();

            if (rdbLessons.Checked)
            {
                Properties.Settings.Default.AssignmentType = AssignmentType.Lesson;
            }
            else if (rdbReviews.Checked)
            {
                Properties.Settings.Default.AssignmentType = AssignmentType.Review;
            }

            if (Properties.Settings.Default.AssignmentType == AssignmentType.Lesson)
            {
                
                WaniKaniLesson wkForm = new WaniKaniLesson();
                wkForm.Show();
                this.Hide();
            }
            else if (Properties.Settings.Default.AssignmentType == AssignmentType.Review)
            {
                this.Hide();
                WaniKaniReview wkForm = new WaniKaniReview();
                wkForm.Show();
            }

            
        }

        private void frmWKSettings_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.StudyTypes.Contains("radical"))
            {
                clbStudyTypes.SetItemChecked(0, true);
            }

            if (Properties.Settings.Default.StudyTypes.Contains("kanji"))
            {
                clbStudyTypes.SetItemChecked(1, true);
            }

            if (Properties.Settings.Default.StudyTypes.Contains("vocabulary"))
            {
                clbStudyTypes.SetItemChecked(2, true);
            }

            if(Properties.Settings.Default.AssignmentType.HasFlag(AssignmentType.Lesson))
            {
                rdbLessons.Checked = true;
            }

            if (Properties.Settings.Default.AssignmentType.HasFlag(AssignmentType.Review))
            {
                rdbReviews.Checked = true;
            }

            txtAPIKey.Text = Properties.Settings.Default.APIKey;
        }
    }
}
