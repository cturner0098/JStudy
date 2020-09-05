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
            var deserialized = JObject.Parse(Assignment.GetAllAssignments(parameters))
                .Root
                .SelectToken("total_count")
                .ToString();
            lblReviewsAvailable.Text = deserialized;
        }
    }
}
