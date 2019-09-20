namespace Models
{
    public class AttemptResponse
    {

        public AttemptResponse(bool response)
        {
            Response = response;
        }

        public bool Response { get; set; }
    }
}