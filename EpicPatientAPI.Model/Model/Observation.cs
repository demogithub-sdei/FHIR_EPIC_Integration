using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class Observation
    {
        public string resourceType { get; set; }
        public string type { get; set; }
        public int total { get; set; }
        public List<Link> link { get; set; }
        public List<Entry> entry { get; set; }
        public Status Status { get; set; } = new Status();
    }

    public class Category
    {
        public List<Coding> coding { get; set; }
        public string text { get; set; }
    }

    public class Code
    {
        public List<Coding> coding { get; set; }
        public string text { get; set; }
    }

    public class Subject
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    public class Encounter
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    public class Performer
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    public class ValueQuantity
    {
        public double value { get; set; }
        public string unit { get; set; }
        public string system { get; set; }
        public string code { get; set; }
    }
}
