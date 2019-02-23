using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _03.RequestParser
{
    public class StartUp
    {
        public static void Main()
        {
            var endpointsByHttpMethod = new Dictionary<string, HashSet<string>>();

            var input = Console.ReadLine().ToLower();

            while (input != "END")
            {
                var splitInput = input.Split("/", StringSplitOptions.RemoveEmptyEntries);

                var httpMethod = splitInput[1];
                var endPoint = splitInput[0];

                if (!endpointsByHttpMethod.ContainsKey(httpMethod))
                {
                    endpointsByHttpMethod.Add(httpMethod, new HashSet<string>());
                }

                endpointsByHttpMethod[httpMethod].Add(endPoint);
                input = Console.ReadLine();
            }

            var requestString = Console.ReadLine().ToLower();

            var requestStringSplit = requestString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var requestHttpMethod = requestStringSplit[0];
            var requestEndPoint = requestStringSplit[1].Trim('/');
            var requestHttpProtocol = requestStringSplit[2];

            if (endpointsByHttpMethod.ContainsKey(requestHttpMethod))
            {
                var endpoint = endpointsByHttpMethod[requestHttpMethod]
                    .FirstOrDefault(e => e == requestEndPoint);

                if (endpoint != null)
                {
                    var successHttpResponse = $"{requestHttpProtocol} {(int)HttpStatusCode.OK} {HttpStatusCode.OK}" +
                        $"{Environment.NewLine}" +
                        $"Content - Length: {HttpStatusCode.OK.ToString().Length}" +
                        $"{Environment.NewLine}" +
                        $"Content-Type: text/plain" +
                        $"{Environment.NewLine}" +
                        $"{Environment.NewLine}" +
                        $"{HttpStatusCode.OK}";

                    Console.WriteLine(successHttpResponse);
                    return;
                }
            }
            var errorHttpResponse = $"{requestHttpProtocol} {(int)HttpStatusCode.NotFound} {HttpStatusCode.NotFound}" +
                   $"{Environment.NewLine}" +
                   $"Content - Length: {HttpStatusCode.NotFound.ToString().Length}" +
                   $"{Environment.NewLine}" +
                   $"Content-Type: text/plain" +
                   $"{Environment.NewLine}" +
                   $"{Environment.NewLine}" +
                   $"{HttpStatusCode.NotFound}";

            Console.WriteLine(errorHttpResponse);
        }
    }
}
