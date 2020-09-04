//https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebrequest.headers?view=netcore-3.1
//https://stackoverflow.com/questions/40402782/how-to-pass-api-key-through-httpwebrequest/40402986
//https://docs.api.wanikani.com/20170710/?javascript#get-all-reviews
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
            string wanikaniRevision = "20170710";
            string apiKey = "500ce2a7-c0b6-4361-b4fa-c74081b123ca";
            string authHeader = "Bearer " + apiKey;
            string apiEndpoint = "reviews";
            HttpWebRequest client = (HttpWebRequest)WebRequest.Create("https://api.wanikani.com/v2/" + apiEndpoint);
            client.Headers["Authorization"] = authHeader;
            client.Headers["Wanikani-Revision"] = wanikaniRevision;

            HttpWebResponse clientResposne = (HttpWebResponse)client.GetResponse();

            Stream streamResposne = clientResposne.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResposne);
            Char[] readBuff = new char[256];
            int count = streamRead.Read(readBuff, 0, 256);
            while(count > 0)
            {
                String outputData = new string(readBuff, 0, count);
                rtbOutput.AppendText("Line " + count + " " + outputData);
                count = streamRead.Read(readBuff, 0, 256);
            }

            streamResposne.Close();
            streamRead.Close();
            clientResposne.Close();
        }
    }
}
