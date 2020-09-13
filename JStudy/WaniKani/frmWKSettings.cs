﻿using System;
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
    public partial class frmWKSettings : Form
    {
        public frmWKSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<String> studyTypes = new List<string>();
            foreach (Object item in clbStudyTypes.CheckedItems)
            {
                studyTypes.Add(item.ToString().ToLower());
            }

            Properties.Settings.Default.StudyTypes = string.Join(",", studyTypes);
            Properties.Settings.Default.Save();
        }
    }
}
