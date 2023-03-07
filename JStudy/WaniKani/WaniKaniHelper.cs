using JStudy.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JStudy.WaniKani
{
    public class WaniKaniHelper
    {
        static string wanikaniRevision = "20170710";
        static string apiKey = Properties.Settings.Default.APIKey;
        static string authHeader = "Bearer " + apiKey;

        public static string GetJsonData(string endPoint, Dictionary<string,string>? queryParameters)
        {
            HttpWebRequest client;
            if (queryParameters != null)
            {
                client = (HttpWebRequest)WebRequest.Create(endPoint + HttpRequests.BuildQueryParameters(queryParameters));
            }
            else
            {
                client = (HttpWebRequest)WebRequest.Create(endPoint);
            }

            client.Headers["Authorization"] = authHeader;
            client.Headers["Wanikani-Revision"] = wanikaniRevision;

            HttpWebResponse clientResposne;
            try
            {
                // TODO: ADD API VERIFICATION
                clientResposne = (HttpWebResponse)client.GetResponse();
            } catch(WebException webEx)
            {
                clientResposne = null;
                MessageBox.Show(webEx.Message);
                WaniKaniSetting wkSettings = new WaniKaniSetting();
                wkSettings.ShowDialog();
                GetJsonData(endPoint, queryParameters);
            }
            

            Stream streamResposne = clientResposne.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResposne, Encoding.UTF8);
            Char[] readBuff = new char[256];
            int count = streamRead.Read(readBuff, 0, 256);

            //string json = streamRead.ReadToEnd();
            string json = "";
            while (count > 0)
            {
                String outputData = new string(readBuff, 0, count);
                json += outputData;
                count = streamRead.Read(readBuff, 0, 256);
            }
            streamResposne.Close();
            streamRead.Close();
            clientResposne.Close();

            return json;
        }

        public async static Task<string> PostJsonData(string endPoint, JObject obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = endPoint;
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", authHeader);
            client.DefaultRequestHeaders.Add("Wanikani-Revision", wanikaniRevision);

            var response = await client.PostAsync(url, data);

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
