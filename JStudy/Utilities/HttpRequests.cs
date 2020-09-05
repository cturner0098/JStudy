using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JStudy.Utilities
{
    static class HttpRequests
    {
        public static string BuildQueryParameters(Dictionary<string, string> queryParameters)
        {
            string query = "?";
            foreach (KeyValuePair<string, string> parameters in queryParameters)
            {
                query += parameters.Key;
                if(parameters.Value != "")
                {
                    query += "=" + parameters.Value;
                }
                query += "&";
            }

            return query;
        }
    }
}
