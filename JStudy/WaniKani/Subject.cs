﻿using Newtonsoft.Json.Linq;
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
        public string Character { get; set; }
        public List<String> Meanings { get; set; }
        public List<String> Readings { get; set; }

        static string endPoint = "https://api.wanikani.com/v2/subjects";

        public Subject(int id, string @object, int level, string character, List<String> meanings, List<String>? readings)
        {
            Id = id;
            Object = @object;
            Level = level;
            Character = character;
            Meanings = meanings;
            Readings = readings;
        }

        public static string GetAllSubjects(Dictionary<string, string>? queryParameters)
        {
            return GetJsonData(endPoint, queryParameters);
        }
        
        public static List<Subject> BuildSubjectList(string subjectIDList)
        {
            if(string.IsNullOrWhiteSpace(subjectIDList))
            {
                return null;
            }
            // Create parameters 
            // TODO: user selected
            // ids need to have their own join method, can program in GetAvailableAssignments
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("ids", subjectIDList);
            parameters.Add("types", Properties.Settings.Default.StudyTypes);

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

                var character = (string)data["data"]["characters"] ?? "null";

                try
                {
                   var readingList =
                    from readings in data["data"]["readings"]
                    select (string)readings["reading"];

                    subjectList.Add(new Subject((int)data["id"], (string)data["object"], (int)data["data"]["level"], character, meaningList.ToList<string>(), readingList.ToList<string>()));
                } catch(Exception ex)
                {
                    subjectList.Add(new Subject((int)data["id"], (string)data["object"], (int)data["data"]["level"], character, meaningList.ToList<string>(), null));
                }
                

                
            }
            return subjectList;
        }
    }
}
