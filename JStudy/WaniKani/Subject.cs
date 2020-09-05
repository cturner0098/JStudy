using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JStudy.WaniKani
{
    class Subject : WaniKaniHelper
    {
        static string endPoint = "https://api.wanikani.com/v2/subjects";
        public static string GetAllSubjects(Dictionary<string, string>? queryParameters)
        {
            return GetJsonData(endPoint, queryParameters);
        }
    }
}
