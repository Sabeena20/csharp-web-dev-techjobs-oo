using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        // TEST FOR SETTING JOB ID
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsTrue(job2.Id - 1 == job1.Id);
        }

        // TEST FOR SETTING ALL FIELDS
        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {
            Employer EmployerName = new Employer("ACME");
            Location EmployerLocation = new Location("Desert");
            PositionType JobType = new PositionType("Quality control");
            CoreCompetency JobCoreCompetency = new CoreCompetency("Persistence");

            Job job1 = new Job("Product tester", EmployerName, EmployerLocation, JobType, JobCoreCompetency);

            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.ToString());
            Assert.AreEqual("Product tester", job1.Name);
        }

        // TEST FOR TWO OBJECTS ARE EQUAL
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Equals(job2));
        }

        // TEST FOR TEST NEW LINE
        [TestMethod]
        public void ToStringTestNewLine()
        {
            Employer EmployerName = new Employer("ACME");
            Location EmployerLocation = new Location("Desert");
            PositionType JobType = new PositionType("Quality control");
            CoreCompetency JobCoreCompetency = new CoreCompetency("Persistence");
            Job job1 = new Job("Product tester", EmployerName, EmployerLocation, JobType, JobCoreCompetency);

            string[] values = job1.ToString().Split(Environment.NewLine);

            Console.WriteLine(job1.ToString());
            Assert.AreEqual("", values[0]);
            Assert.AreEqual("", values[7]);

        }

        // TEST FOR LABEL
        [TestMethod]
        public void ToStringTestLabel()
        {
            Employer EmployerName = new Employer("ACME");
            Location EmployerLocation = new Location("Desert");
            PositionType JobType = new PositionType("Quality control");
            CoreCompetency JobCoreCompetency = new CoreCompetency("Persistence");
            Job job1 = new Job("Product tester", EmployerName, EmployerLocation, JobType, JobCoreCompetency);
            
            string[] values = job1.ToString().Split(Environment.NewLine);

            Assert.AreEqual("ID: 7", values[1]);
            Assert.AreEqual("Name: Product tester", values[2]);
            Assert.AreEqual("Employer: ACME", values[3]);
            Assert.AreEqual("Location: Desert", values[4]);
            Assert.AreEqual("Position Type: Quality control", values[5]);
            Assert.AreEqual("Core Competency: Persistence", values[6]);
        }

        // TEST FOR EMPTY FIELDS
        [TestMethod]

        public void ToStringEmptyFields()
        {
            Employer EmployerName = new Employer("ACME");
            Location EmployerLocation = new Location("Desert");
            PositionType JobType = new PositionType("Quality control");
            CoreCompetency JobCoreCompetency = new CoreCompetency("Persistence");
            Job job1 = new Job(null, EmployerName, null, JobType, JobCoreCompetency);

            string[] values = job1.ToString().Split(Environment.NewLine);
            Assert.AreEqual("ID: 6", values[1]);
            Assert.AreEqual("Name:Data not available", values[2]);
            Assert.AreEqual("Employer: ACME", values[3]);
            Assert.AreEqual("Location:Data not available", values[4]);
            Assert.AreEqual("Position Type: Quality control", values[5]);
            Assert.AreEqual("Core Competency: Persistence", values[6]);


        }


    }
}
