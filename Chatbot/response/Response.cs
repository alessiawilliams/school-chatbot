using System.Text.RegularExpressions;

namespace Chatbot.response
{
    public class Response
    {
        // Fields:
        protected int Id;
        protected Regex Trigger;
        protected string Text;

        public Response()
        {
            // TODO: Deserialize JSON to assign values
        }
    }
    
    // Data type: ResponseSet. Each initialized Chatbot must have a ResponseSet.
    public class ResponseSet : IResponseSet
    {
        // Fields:
        private Chatbot bot;
        
        public ResponseSet(Chatbot bot)
        {
            this.bot = bot;
        }
        
        public ResponseSet Compile()
        {
            // TODO: Implement method which collects responses
            throw new System.NotImplementedException();
        }
    }
}