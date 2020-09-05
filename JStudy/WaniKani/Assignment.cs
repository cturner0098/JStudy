using JStudy.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JStudy.WaniKani
{
    public class Assignment
    {
        static string wanikaniRevision = "20170710";
        static string apiKey = "500ce2a7-c0b6-4361-b4fa-c74081b123ca";
        static string authHeader = "Bearer " + apiKey;
        static string endPoint = "https://api.wanikani.com/v2/assignments";

        public Assignment()
        {

        }
        public static string GetAllAssignments(Dictionary<string, string>? queryParameters = null)
        {
            HttpWebRequest client;
            if (queryParameters != null)
            {
                client = (HttpWebRequest)WebRequest.Create(endPoint + HttpRequests.BuildQueryParameters(queryParameters));
            } else
            {
                client = (HttpWebRequest)WebRequest.Create(endPoint);
            }
            
            client.Headers["Authorization"] = authHeader;
            client.Headers["Wanikani-Revision"] = wanikaniRevision;

            HttpWebResponse clientResposne = (HttpWebResponse)client.GetResponse();

            Stream streamResposne = clientResposne.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResposne);
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
    }

    /*public partial class Assignment
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        [JsonProperty("date_updated_at")]
        public string DateUpdatedAt { get; set; }
        [JsonProperty("data")]
        public List<DataResponse> Data { get; set; }
    }
    public partial class Resposne
    {
        [JsonProperty("object")]
        public string Object { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("pages")]
        public List<Page> Pages { get; set; }
       
        [JsonProperty("data")]
        public List<DataResponse> Data { get; set; }
    }

    public partial class Page
    {
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("next_url")]
        public string NextURL { get; set; }
        [JsonProperty("previous_url")]
        public string PreviousURL { get; set; }
    }

    public partial class DataResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("date_updated_at")]
        public string DateUpdatedAt { get; set; }
        public List<Data> Data { get; set; }

    }

    public partial class Data
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("subject_id")]
        public int SubjectID { get; set; }
        [JsonProperty("subject_type")]
        public string SubjectType { get; set; }
        [JsonProperty("srs_stage")]
        public int SRSStage { get; set; }
        [JsonProperty("unlocked_at")]
        public string UnlockedAt { get; set; }
        [JsonProperty("started_at")]
        public string StartedAt { get; set; }
        [JsonProperty("passed_at")]
        public string PassedAt { get; set; }
        [JsonProperty("burned_at")]
        public string BurnedAt { get; set; }
        [JsonProperty("available_at")]
        public string AvailableAt { get; set; }
        [JsonProperty("resurrected_at")]
        public string ResurrectedAt { get; set; }

    }*/
}
