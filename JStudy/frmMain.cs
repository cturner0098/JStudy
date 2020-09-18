//https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebrequest.headers?view=netcore-3.1
//https://stackoverflow.com/questions/40402782/how-to-pass-api-key-through-httpwebrequest/40402986
//https://docs.api.wanikani.com/20170710/?javascript#get-all-reviews
using JStudy.WaniKani;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JStudy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.WKSettings == false ||
                Properties.Settings.Default.APIKey == "")
            {
                Properties.Settings.Default.WKSettings = false;
                Properties.Settings.Default.Save();
            }
            
        }

        private void btnWaniKani_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWaniKani wkForm = new frmWaniKani();
            wkForm.Show();    
        }
    }
}
