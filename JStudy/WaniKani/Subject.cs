using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JStudy.WaniKani
{
    class Subject : WaniKaniHelper
    {
        public int Id { get; set; }
        public string Object { get; set; }
        public int Level { get; set; }
        public string Slug { get; set; }
        public List<String> Meanings { get; set; }
        public List<String> Readings { get; set; }

        static string endPoint = "https://api.wanikani.com/v2/subjects";

        public Subject(int id, string @object, int level, string slug, List<String> meanings, List<String> readings)
        {
            Id = id;
            Object = @object;
            Level = level;
            Slug = slug;
            Meanings = meanings;
            Readings = readings;
        }

        public static string GetAllSubjects(Dictionary<string, string>? queryParameters)
        {
            return GetJsonData(endPoint, queryParameters);
        }
        
        public static List<Subject> BuildSubjectList()
        {
            // Create parameters 
            // TODO: user selected
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("immediately_available_for_review", "");
            parameters.Add("subject_types", "kanji");


            // Fetch assignments
            var assignments = JObject.Parse(Assignment.GetAllAssignments(parameters));

            var availableSubjectIds =
                from id in assignments["data"].Children()["data"]
                select (int)id["subject_id"];

            // Create List of Subject Ids
            var subjectJoin = string.Join(",", availableSubjectIds);
            parameters.Clear();
            parameters.Add("ids", subjectJoin);

            // Fetch Subjects
            var subjects = JObject.Parse(Subject.GetAllSubjects(parameters));

            // Build Subject List
            List<Subject> subjectList = new List<Subject>();
            var subjectKanji = subjects["data"].Children();

            foreach(var data in subjectKanji)
            {
                var meaningList =
                    from meanings in data["data"]["meanings"]
                    select (string)meanings["meaning"];

                var readingList =
                    from readings in data["data"]["readings"]
                    select (string)readings["reading"];

                subjectList.Add(new Subject((int)data["id"], (string)data["object"], (int)data["data"]["level"], (string)data["data"]["slug"], meaningList.ToList<string>(), readingList.ToList<string>()));
            }
            return subjectList;
        }
    }
}
