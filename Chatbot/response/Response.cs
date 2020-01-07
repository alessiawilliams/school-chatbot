using System.Text.RegularExpressions;

namespace Chatbot.response
{
    public class Response
    {
        // Fields:
        protected int Id;
        protected Regex Trigger;
        protected string Text;
    }
    
    // Data type: ResponseSet. Each initialized Chatbot must have a ResponseSet.
    public class ResponseSet : IResponseSet
    {
        // Fields:
        private Chatbot bot;
        private List<Response> set; 
        
        public ResponseSet(Chatbot bot)
        {
            this.bot = bot;
            this.Compile();
        }
        
        public ResponseSet Compile()
        {
            this.set = JsonConvert.DeserializeObject<List<Response>>(); // << Read in and add JSON
        }
    }
}
