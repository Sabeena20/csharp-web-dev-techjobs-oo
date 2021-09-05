using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.IsTrue(job2.Id - 1 == job1.Id);
        }

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

        [TestMethod]

        public void TestJobsForEquality()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Equals(job2));
        }

    }
}
