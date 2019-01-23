using System.Runtime.InteropServices.ComTypes;

namespace Archysoft.D1.Web.Api.Model
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public string Description { get; set; }
        public long Timestamp { get; set; }
    }

    public class ApiResponse<T> : ApiResponse where T : class
    {
        public T Model { get; set; }
    }
}
