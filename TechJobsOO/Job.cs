using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
           string value = "";
           bool allEmptyExceptId = false;

            if (this.Id == 0)
            {
               value = value + Environment.NewLine + "ID:Data not available" + Environment.NewLine;
            } else
            {
               value =  Environment.NewLine
             + "ID: " + this.Id + Environment.NewLine;
            }

            if (this.Name == null || this.Name == "")
            {
                value = value  + "Name:Data not available" + Environment.NewLine;
                allEmptyExceptId = true;
            }
            else
            {
                value = value
              + "Name: " + this.Name + Environment.NewLine;
                allEmptyExceptId = false;
            }

            if (this.EmployerName == null || this.EmployerName.Value == "")
            {
                value = value + "Employer:Data not available" + Environment.NewLine;
                allEmptyExceptId = true;
            }
            else
            {
                value = value
              + "Employer: " + this.EmployerName + Environment.NewLine;
                allEmptyExceptId = false;
            }

            if (this.EmployerLocation == null || this.EmployerLocation.Value == "")
            {
                value = value + "Location:Data not available" + Environment.NewLine;
                allEmptyExceptId = true;
            }
        
            else
            {
                value = value
              + "Location: " + this.EmployerLocation + Environment.NewLine;
                allEmptyExceptId = false;
            }

            if (this.JobType == null || this.JobType.Value == "")
            {
                value = value + "Position Type:Data not available" + Environment.NewLine;
                allEmptyExceptId = true;
            }
        
            else
            {
                value = value
              + "Position Type: " + this.JobType + Environment.NewLine;
                allEmptyExceptId = false;
            }

            if (this.JobCoreCompetency == null || this.JobCoreCompetency.Value == "")
            {
                value = value + "Core Competency:Data not available" + Environment.NewLine;
                allEmptyExceptId = true;
            }
        
            else
            {
                value = value
              + "Core Competency: " + this.JobCoreCompetency + Environment.NewLine;
                allEmptyExceptId = false;
            }

            if(allEmptyExceptId == true)
            {
                value = "OOPS! This job does not seem to exist.";
            }

            return value;
        }


    }
}
