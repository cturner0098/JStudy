// https://docs.api.wanikani.com/20170710/#get-all-assignments
using JStudy.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public static string GetAvailableReviews()
        {
            // Create parameters 
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "immediately_available_for_review", "" },
                { "subject_types", Properties.Settings.Default.StudyTypes }
            };

            // Fetch assignments
            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));

            var availableSubjectIds =
                from id in assignments["data"].Children()["data"]
                select (int)id["subject_id"];

            // Create List of Subject Ids
            var subjectJoin = string.Join(",", availableSubjectIds);
            return subjectJoin;
        }

        public static string GetAvailableLessons()
        {
            // Create parameters 
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "immediately_available_for_lessons", "" },
                { "subject_types", Properties.Settings.Default.StudyTypes }
            };

            // Fetch assignments
            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));

            var availableSubjectIds =
                from id in assignments["data"].Children()["data"]
                select (int)id["subject_id"];

            // Create List of Subject Ids
            var subjectJoin = string.Join(",", availableSubjectIds);
            return subjectJoin;
        }

        public static int GetAvailableReviewCount()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("immediately_available_for_review", "");
            parameters.Add("subject_types", Properties.Settings.Default.StudyTypes);

            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));
            var availableReviews = assignments
                .Root
                .SelectToken("total_count");
            return (int)availableReviews;
        }

        public static int GetAvailableLessonsCount()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("immediately_available_for_lessons", "");
            parameters.Add("subject_types", Properties.Settings.Default.StudyTypes);

            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));
            var availableReviews = assignments
                .Root
                .SelectToken("total_count");
            return (int)availableReviews;
        }

        public static int StartAssignment(int id)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("immediately_available_for_lessons", "");
            parameters.Add("subject_types", Properties.Settings.Default.StudyTypes);

            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));
            var availableReviews = assignments
                .Root
                .SelectToken("total_count");
            return (int)availableReviews;
        }
    }
}
