using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Chatbot.response
{
    public class Response
    {
        // Fields:
        public int Id { get; set; }
        public Regex Trigger { get; set; }
        public string Text { get; set; }
    }
    
    // Data type: ResponseSet. Each initialized Chatbot must have a ResponseSet.
    public class ResponseSet : IResponseSet
    {
        // Fields:
        public List<Response> Set; 
        
        public ResponseSet()
        {
            this.Compile();
        }
        
        public void Compile()
        {
            this.Set = JsonConvert.DeserializeObject<List<Response>>(File.ReadAllText(@"response\responses.json"));
            Console.WriteLine("ResponseSet created");
        }
    }
}
