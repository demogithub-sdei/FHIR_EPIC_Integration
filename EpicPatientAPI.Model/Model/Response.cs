using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class Response<T>
    {
        public T Data { get; set; }
        public Status Status { get; set; } = new Status();
    }
    public class Status
    {
        public HttpStatusCode Code { get; set; } = HttpStatusCode.OK;
        public string Message { get; set; } = "Success";
    }

    public class MDIResponse
    {
        public string transfer_id { get; set; }
        public bool is_success { get; set; } = false;
    }

    public class epictoken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }
    }
}
