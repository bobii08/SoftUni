namespace BangaloreUniversityLearningSystem.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Utilities;

    public class Route : IRoute
    {
        public Route(string routeUrl)
        {
            this.Parse(routeUrl);
        }

        public IDictionary<string, string> Parameters { get; private set; }

        public string ActionName { get; private set; }

        public string ControllerName { get; private set; }

        private void Parse(string routeUrl)
        {
            string[] parts = routeUrl.Split(new[] { "/", "?" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2)
            {
                throw new InvalidOperationException("The provided route is invalid.");
            }

            this.ControllerName = parts[0] + Constants.ControllerSuffix; 
            this.ActionName = parts[1];
            if (parts.Length >= 3)
            {
                this.Parameters = new Dictionary<string, string>();
                string[] parameterPairs = parts[2].Split(Constants.ParametersPairsSplitChar);
                foreach (var pair in parameterPairs)
                {
                    string[] nameValuePair = pair.Split(Constants.KeyValuePairsSplitChar);
                    string decodedName = WebUtility.UrlDecode(nameValuePair[0]);
                    string decodedValue = WebUtility.UrlDecode(nameValuePair[1]);
                    this.Parameters.Add(decodedName, decodedValue); 
                }
            }
        }
    }
}