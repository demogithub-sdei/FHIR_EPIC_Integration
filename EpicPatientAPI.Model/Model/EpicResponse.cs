using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class EpicResponse
    {
        public DemographicsInfo DemographicsInfo { get; set; }
        public Coverage Coverage { get; set; }
        public Observation Observation { get; set; }
    }
}
