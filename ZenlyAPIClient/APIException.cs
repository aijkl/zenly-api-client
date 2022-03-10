using System;
using System.Net;
using System.Net.Http;

namespace Zenly.APIClient
{
    public class APIException : Exception
    {
        public APIException(HttpStatusCode httpStatusCode, HttpResponseMessage httpResponseMessage, string message = "", Exception innerException = null) : base(message, innerException)
        {
            HttpStatusCode = httpStatusCode;
            HttpResponseMessage = httpResponseMessage;
        }

        public HttpStatusCode HttpStatusCode { set; get; }
        public HttpResponseMessage HttpResponseMessage { set; get; }
    }
}
