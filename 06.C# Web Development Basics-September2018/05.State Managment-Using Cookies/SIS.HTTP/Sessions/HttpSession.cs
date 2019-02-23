namespace SIS.HTTP.Sessions
{
    using SIS.HTTP.Sessions.Contracts;
    using System;
    using System.Collections.Generic;

    public class HttpSession : IHttpSession
    {
        private readonly Dictionary<string, object> sessionParameters;

        public HttpSession(string id)
        {
            this.Id = id;
            this.sessionParameters = new Dictionary<string, object>();
        }

        public string Id { get; }


        public object GetParameter(string name)
        {
            if (string.IsNullOrEmpty(nameof(name)))
            {
                throw new ArgumentException(name);
            }

            return this.sessionParameters.GetValueOrDefault(name, null);
        }

        public bool ContainsParameter(string name, object parameter)
        {
            if (string.IsNullOrEmpty(nameof(name)))
            {
                throw new ArgumentException(name);
            }

            return this.sessionParameters.ContainsKey(name);
        }

        public void ClearParameters()
        {
            this.sessionParameters.Clear();
        }

        public void AddParameter(string name, object parameter)
        {
            if (string.IsNullOrEmpty(nameof(name)))
            {
                throw new ArgumentException(name);
            }

            this.sessionParameters.Add(name, parameter);
        }
    }
}
