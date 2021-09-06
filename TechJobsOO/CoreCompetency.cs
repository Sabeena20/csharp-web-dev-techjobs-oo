using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
       /* private int id { get; set; }
        private static int nextId = 1;
        private string value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }*/

        public CoreCompetency(string v) : base(v)
        {
            Value = v;
        }

        /*public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }*/
    }
    
}
