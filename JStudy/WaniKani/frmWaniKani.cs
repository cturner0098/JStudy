// https://docs.api.wanikani.com/20170710/#create-a-review
// https://docs.api.wanikani.com/20170710/#get-all-assignments
using Newtonsoft.Json.Linq;
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
    public partial class frmWaniKani : Form
    {
        public frmWaniKani()
        {
            InitializeComponent();
        }

        private void frmWaniKani_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("immediately_available_for_review", "");
            //parameters.Add("levels", "10");
            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));
            var availableReviews = assignments
                .Root
                .SelectToken("total_count")
                .ToString();
            lblReviewsAvailable.Text = availableReviews;

            var availableSubjectIds =
                from id in assignments["data"].Children()["data"]
                select (int)id["subject_id"];

            var subjectJoin = string.Join(",", availableSubjectIds);
            parameters.Clear();
            parameters.Add("ids", subjectJoin);
            var subjects = JObject.Parse(Subject.GetAllSubjects(parameters));

            var subjectKanji =
                from character in subjects["data"].Children()["data"]
                select (string)character["characters"];

            for(int i = 0; i < availableSubjectIds.ToList().Count; i++)
            {
                rtbSubjectIDs.Text += availableSubjectIds.ToList()[i].ToString() + " - " + subjectKanji.ToList()[i].ToString() + "\n";
            }
        }
    }
}
