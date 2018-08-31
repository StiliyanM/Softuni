﻿namespace SoftUni.WebServer.Server.Interfaces
{
    using SoftUni.WebServer.Http.Interfaces;

    public interface IHttpRequestHandler
    {
        IHttpResponse Handle(IHttpRequest request);
    }
}
