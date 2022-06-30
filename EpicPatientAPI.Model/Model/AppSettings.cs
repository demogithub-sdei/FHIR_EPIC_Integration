using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class AppSettings
    {
        public string GetSecurityTokenUserName { get; set; }
        public string GetSecurityTokenPassword { get; set; }
        public string Appname { get; set; }
        public string AppUserID { get; set; }
        public string AppPassword { get; set; }
        public string sunriseGetTokenApiUrl { get; set; }
        public string sunriseRetireSecurityTokenApiUrl { get; set; }
        public string SunriseMagicJson { get; set; }
        public string CeibaSendLabResults { get; set; }
        public string CeibaSendDoctorNotes { get; set; }
        public string CeibaAuthApi { get; set; }
        public string CeibaAcceptPatientApi { get; set; }
        public string CeibaDischargePatientApi { get; set; }
        public string CeibaTransferPatientApi { get; set; }
        public string CeibaModifyDemographicPatientApi { get; set; }
        public string uniqueKey { get; set; }
    }
}
