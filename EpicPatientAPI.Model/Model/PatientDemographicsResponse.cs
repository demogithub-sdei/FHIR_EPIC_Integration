using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class PatientDemographicsResponse
    {
        public string MedicalRecordNumber { get; set; }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Weight { get; set; }
        public string Line { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public List<CoverageData> CoverageData { get; set; }
    }

    public class CoverageData
    {
        public string CoverageId { get; set; }
        public List<Payor> Payor { get; set; }
        public Plan Plan { get; set; }
        public BllingAddress BllingAddress { get; set; }
    }

    public class Plan
    {
        public string Value { get; set; }
        public string Name { get; set; }
    }

    public class BllingAddress
    {
        public string Line { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
