using NUnit.Framework;

namespace JobApplicationLibrary.UnitTest
{
    public class ApplicationEvaluateUnitTest
    {

        [Test]
        public void Application_WithUnderAge_TransferredToAutoRejected()
        {
           var evaluator = new ApplicationEvaluator();

            var jobApplication = new JobApplication()
            {
                Applicant = new Applicant()
                {
                    Age=17
                }
            };


            var result = evaluator.Evaluate(jobApplication);


            Assert.AreEqual(result,ApplicationResult.AutoRejected);

        }
    }
}