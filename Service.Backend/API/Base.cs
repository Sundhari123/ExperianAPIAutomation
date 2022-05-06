using System;
using System.IO;
using System.Net;
using NUnit.Framework;

namespace Service.Backend.API
{
    public class Base
    {
        public string GetResponse(WebRequest request, HttpStatusCode code)
        {
            var webResponse = (HttpWebResponse)request.GetResponse();

            Assert.That(webResponse.StatusCode == code,
                $"Api status code is {webResponse.StatusCode} not {code}");

            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream ?? throw new InvalidOperationException("Response data is null"));

            return reader.ReadToEnd();
        }
    }
}
