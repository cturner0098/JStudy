// https://docs.api.wanikani.com/20170710/#create-a-review

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JStudy.WaniKani
{
    public partial class frmWaniKani : Form
    {
        List<Subject> subjectList;
        int incorrectMeaning = 0;
        int incorrectReading = 0;

        public frmWaniKani()
        {
            InitializeComponent();
        }

        private void frmWaniKani_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("immediately_available_for_review", "");
            parameters.Add("subject_types", "kanji");

            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));
            var availableReviews = assignments
                .Root
                .SelectToken("total_count")
                .ToString();
            lblReviewsAvailable.Text += availableReviews;

            subjectList = Subject.BuildSubjectList();

            LoadNextSubject();
            // lblReviewsAvailable.Text = subjectList[0].Meanings[0] + " " + subjectList[0].Readings[0];
        }

        public void LoadNextSubject()
        {
            lblSlug.Text = subjectList[0].Slug;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            bool correct = false;
            foreach(string meaning in subjectList[0].Meanings)
            {
                if(txtMeaning.Text.ToLower() == meaning.ToLower())
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

            foreach (string reading in subjectList[0].Readings)
            {
                if (txtReading.Text.ToLower() == reading.ToLower())
                {
                    correct = true;
                    break;
                }
                else
                {
                    correct = false;
                }
            }

            if (!correct)
                incorrectReading++;

            if (correct)
            {
                await Review.CreateReview(subjectList[0].Id, incorrectMeaning, incorrectReading);
                subjectList.RemoveAt(0);
                LoadNextSubject();

                incorrectMeaning = 0;
                incorrectReading = 0;
                txtMeaning.Text = "";
                txtReading.Text = "";
            }
        }
    }
}
