using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using WebApplication1.ServiceModel;

namespace WebApplication1.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }

        public object Any(Plus request)
        {
            return new PlusResponse {Result = request.A + request.B};
        }

        public object Any(Sub request)
        {
            return new SubResponse {Result = request.A - request.B};
        }
    }
}