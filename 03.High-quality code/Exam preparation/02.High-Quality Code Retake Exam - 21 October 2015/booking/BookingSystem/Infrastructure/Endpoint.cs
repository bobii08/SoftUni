using BookingSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Net;
using BookingSystem.Interfaces;

namespace BookingSystem.Infrastructure
{
    public class Endpoint : IEndpoint
    {
        public Endpoint(string url)
        {
            this.Parse(url);
        }

        public string ActionName { get; private set; }

        public string ControllerName { get; private set; }

        public IDictionary<string, string> Parameters { get; private set; }

        private void Parse(string url)
        {
            string[] endpointParts = url.Split(
                new[] { "/", "?" },
                StringSplitOptions.RemoveEmptyEntries);
            if (endpointParts.Length < 2)
            {
                throw new InvalidOperationException("The provided route is invalid.");
            }

            string partialControllerName = endpointParts[0];
            this.ControllerName = partialControllerName + Constants.ControllerSuffix;
            this.ActionName = endpointParts[1];
            if (endpointParts.Length >= 3)
            {
                this.Parameters = new Dictionary<string, string>();
                string[] parameterPairs = endpointParts[2].Split(Constants.PairsSeparator);
                foreach (var pair in parameterPairs)
                {
                    string[] nameAndValue = pair.Split(Constants.PartsSeparator);
                    string name = WebUtility.UrlDecode(nameAndValue[0]);
                    string value = WebUtility.UrlDecode(nameAndValue[1]);

                    if (name.Contains("Id") && name.Length > 2)
                    {
                        name = name.Substring(name.Length - 2).ToLower();
                    }

                    this.Parameters.Add(name, value);
                }
            }
        }
    }
}
