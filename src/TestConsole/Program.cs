﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GoogleMeasurementProtocol;
using GoogleMeasurementProtocol.Parameters.ContentInformation;
using GoogleMeasurementProtocol.Parameters.Timing;
using GoogleMeasurementProtocol.Parameters.User;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new GoogleAnalyticsRequestFactory("UA-xxxxxxx-x");

            var request = factory.CreateRequest(HitTypes.PageView);

            request.Parameters.Add(new DocumentHostName("test.com"));
            request.Parameters.Add(new DocumentPath("/test/testPath2"));
            request.Parameters.Add(new DocumentTitle("test title2"));

            request.Get(Guid.NewGuid());
            request.Post(Guid.NewGuid());

            Console.ReadKey();


        }
    }
}
