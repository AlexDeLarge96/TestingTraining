using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace exampleNET
{
    public class Example
    {
        private Http httpClient;

        public Example(Http httpClient)
        {
            this.httpClient = httpClient;
        }

        static void Main(string[] args)
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string GetTitle()
        {
            string json = new Http().GetData("todos/1").Result;
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json)["title"].ToUpper();
        }
    }
}
