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
    public partial class frmWKLookup : Form
    {
        public frmWKLookup()
        {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("ids", txtCharacter.Text);

            List<Subject> subjectList = Subject.BuildSubjectList(txtCharacter.Text);
            rtbJson.Text = Subject.GetAllSubjects(parameters);
        }
    }
}
