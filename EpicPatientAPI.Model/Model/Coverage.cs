using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class Coverage
    {
        public string resourceType { get; set; }
        public string type { get; set; }
        public int total { get; set; }
        public List<Link> link { get; set; }
        public List<Entry> entry { get; set; }
        public Status Status { get; set; } = new Status();
    }

    public class Subscriber
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    public class Beneficiary
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    public class Relationship
    {
        public List<Coding> coding { get; set; }
        public string text { get; set; }
    }

    public class Period
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Payor
    {
        public string reference { get; set; }
        public Identifier identifier { get; set; }
        public string display { get; set; }
    }

    public class ValueIdentifier
    {
        public string use { get; set; }
        public string system { get; set; }
        public string value { get; set; }
    }

    public class Class
    {
        public Type type { get; set; }
        public string value { get; set; }
        public List<Extension> extension { get; set; }
        public string name { get; set; }
    }

    public class Purpose
    {
        public List<Coding> coding { get; set; }
    }

    public class Contact
    {
        public Purpose purpose { get; set; }
        public Address address { get; set; }
    }

    public class Contained
    {
        public string resourceType { get; set; }
        public string id { get; set; }
        public List<Type> type { get; set; }
        public List<Contact> contact { get; set; }
    }

    public class ValueReference
    {
        public Identifier identifier { get; set; }
        public string display { get; set; }
        public string reference { get; set; }
    }
}
