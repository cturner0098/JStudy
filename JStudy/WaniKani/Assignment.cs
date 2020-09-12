// https://docs.api.wanikani.com/20170710/#get-all-assignments
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
    class Assignment : WaniKaniHelper
    {

        static string endPoint = "https://api.wanikani.com/v2/assignments";

        public static string GetAllAssignments(Dictionary<string, string>? queryParameters = null)
        {
            return GetJsonData(endPoint, queryParameters);
        }
    }
}
