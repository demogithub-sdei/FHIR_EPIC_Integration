using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicPatientAPI.Model.Model
{
    public class DemographicsInfo
    {
        public string resourceType { get; set; }
        public string type { get; set; }
        public int total { get; set; }
        public List<Link> link { get; set; }
        public List<Entry> entry { get; set; }
        public Status Status { get; set; } = new Status();
    }

    public class Link
    {
        public string relation { get; set; }
        public string url { get; set; }
    }

    public class ValueCoding
    {
        public string system { get; set; }
        public string code { get; set; }
        public string display { get; set; }
    }

    public class Extension
    {
        public ValueCoding valueCoding { get; set; }
        public string url { get; set; }
        public string valueString { get; set; }
        public List<Extension> extension { get; set; }
        public ValueCodeableConcept valueCodeableConcept { get; set; }
        public string valueCode { get; set; }

        public ValueIdentifier valueIdentifier { get; set; }
        public ValueReference valueReference { get; set; }
        public bool? valueBoolean { get; set; }
    }

    public class Coding
    {
        public string system { get; set; }
        public string code { get; set; }
        public string display { get; set; }
    }

    public class ValueCodeableConcept
    {
        public List<Coding> coding { get; set; }
    }

    public class Type
    {
        public string text { get; set; }
        public List<Coding> coding { get; set; }
    }

    public class Identifier
    {
        public string use { get; set; }
        public string system { get; set; }
        public string value { get; set; }
        public Type type { get; set; }
    }

    public class Name
    {
        public string use { get; set; }
        public string text { get; set; }
        public string family { get; set; }
        public List<string> given { get; set; }
    }

    public class Telecom
    {
        public string system { get; set; }
        public string value { get; set; }
        public string use { get; set; }
    }

    public class Address
    {
        public string use { get; set; }
        public List<string> line { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }

    public class MaritalStatus
    {
        public string text { get; set; }
    }

    public class GeneralPractitioner
    {
        public string reference { get; set; }
        public string type { get; set; }
        public string display { get; set; }
    }

    public class ManagingOrganization
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    public class Resource
    {
        public string resourceType { get; set; }
        public string id { get; set; }
        public string weight { get; set; }
        public List<Extension> extension { get; set; }
        public List<Identifier> identifier { get; set; }
        public bool active { get; set; }
        public List<Name> name { get; set; }
        public List<Telecom> telecom { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public bool deceasedBoolean { get; set; }
        public List<Address> address { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public List<GeneralPractitioner> generalPractitioner { get; set; }
        public ManagingOrganization managingOrganization { get; set; }

        public string status { get; set; }
        public Subscriber subscriber { get; set; }
        public string subscriberId { get; set; }
        public Beneficiary beneficiary { get; set; }
        public Relationship relationship { get; set; }
        public Period period { get; set; }
        public List<Payor> payor { get; set; }
        public List<Class> @class { get; set; }
        public int order { get; set; }
        public List<Contained> contained { get; set; }

        public List<Category> category { get; set; }
        public Code code { get; set; }
        public Subject subject { get; set; }
        public Encounter encounter { get; set; }
        public DateTime effectiveDateTime { get; set; }
        public DateTime issued { get; set; }
        public List<Performer> performer { get; set; }
        public ValueQuantity valueQuantity { get; set; }
    }

    public class Search
    {
        public string mode { get; set; }
    }

    public class Entry
    {
        public List<Link> link { get; set; }
        public string fullUrl { get; set; }
        public Resource resource { get; set; }
        public Search search { get; set; }
    }
}
