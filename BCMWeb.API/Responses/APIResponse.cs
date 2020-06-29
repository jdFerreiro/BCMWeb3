namespace BCMWeb.API.Responses
{
    public class APIResponse<T>
    {

        public APIResponse(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
