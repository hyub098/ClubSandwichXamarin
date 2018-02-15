using System.Net;

namespace ClubSandwich.Service
{
    public class GraphResult<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }
    }
}