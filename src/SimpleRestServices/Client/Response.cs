﻿using System;
using System.Collections.Generic;
using System.Net;

namespace JSIStudios.SimpleRESTServices.Client
{
    [Serializable]
    public class Response
    {
        public int StatusCode { get; private set; }

        public string Status { get; private set; }

        public IList<HttpHeader> Headers { get; private set; }

        public string RawBody { get; private set; }

        public Response(int responseCode, string status, IList<HttpHeader> headers, string rawBody)
        {
            StatusCode = responseCode;
            Status = status;
            Headers = headers;
            RawBody = rawBody;
        }

        public Response(HttpStatusCode statusCode, IList<HttpHeader> headers, string rawBody)
            : this((int)statusCode, statusCode.ToString(), headers, rawBody)
        {
        }
    }
}
