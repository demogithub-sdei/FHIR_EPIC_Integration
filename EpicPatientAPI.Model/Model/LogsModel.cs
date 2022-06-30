using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class LogsModel
    {
        public string apiname { get; set; }
        public string apifrom { get; set; }
        public string apiresponse { get; set; }
        public DateTime apistarttime { get; set; }
        public DateTime apiendtime { get; set; }
        public string statuscode { get; set; }
        public string serializeData { get; set; }
    }
    public class LabResponseModel
    {
        public int response_code { get; set; }
        public bool is_success { get; set; }
        public string message { get; set; }
    }

    public class PatientATDLog
    {
        public string patientid { get; set; }
        public string encounterid { get; set; }
        public string facility { get; set; }
        public string ehrname { get; set; }
        public DateTime atddate { get; set; }
        public int atdstatus { get; set; }
    }
}
