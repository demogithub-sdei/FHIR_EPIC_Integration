using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class AcceptPatient
    {
        public string medicalRecordNumber { get; set; }
        public string identificationNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public long birthDate { get; set; }
        public long acceptanceDate { get; set; }
        public string visitID { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string nationality { get; set; }
        public string birthPlace { get; set; }
        public string imageUrl { get; set; }
        public string bloodGroup { get; set; }
        public string hospital { get; set; }
        public string department { get; set; }
        public string bed { get; set; }
        public string reason { get; set; }
    }

    public class TransferPatient
    {
        public string medicalRecordNumber { get; set; }
        public string hospital { get; set; }
        public string department { get; set; }
        public string bed { get; set; }
        public string reason { get; set; }
    }

    public class DischargePatient
    {
        public string medicalRecordNumber { get; set; }
        public string hospital { get; set; }
        public string department { get; set; }
        public string bed { get; set; }
        public string reason { get; set; }
        public long dischargeDate { get; set; }
        public string visitID { get; set; }

    }

    public class PatientDemographic
    {
        public string medicalRecordNumber { get; set; }
        public string identificationNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public long birthDate { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string nationality { get; set; }
        public string birthPlace { get; set; }
        public string imageUrl { get; set; }
        public string bloodGroup { get; set; }
        public string reason { get; set; }
    }

    public class ADTData
    {
        public AcceptPatient acceptPatient;
        public DischargePatient dischargePatient;
        public TransferPatient transferPatient;
        public PatientDemographic patientDemographic;

    }
    public class PatientLabRead
    {
        public string patientID { get; set; }
        public long measuredDate { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string unit { get; set; }
        public string testId { get; set; }
        public string max { get; set; }
        public string min { get; set; }
        public string result { get; set; }
        public string loinc { get; set; }
    }

    public class GetDoctorNotes
    {
        public string patient_id { get; set; }
        public string measured_date { get; set; }
        public string note { get; set; }
        public string unique_ehr_id { get; set; }
        public string user { get; set; }
        public string type { get; set; }
        public bool send_from_ceiba { get; set; }

    }
}
