using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JStudy.WaniKani
{
    class Review : WaniKaniHelper
    {
        public int subject_id { get; set; }
        public int incorrect_meaning_answers { get; set; }
        public int incorrect_reading_answers { get; set; }
        static string endPoint = "https://api.wanikani.com/v2/reviews";
        public static string GetAllReviews(Dictionary<string, string>? queryParameters = null)
        {
            return GetJsonData(endPoint, queryParameters);
        }

        public async static Task<string> CreateReview(int subjectId, int incorrectMeaning, int incorrectReading)
        {
            JObject review = new JObject
            {
                { "review", new JObject
                    {
                        { "subject_id", subjectId },
                        { "incorrect_meaning_answers", incorrectMeaning },
                        { "incorrect_reading_answers", incorrectReading }
                    }
                }
            };

            return await PostJsonData(endPoint, review);
        }
    }
}
