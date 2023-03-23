using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AssessmentGoogle
{
    public class GoogleTest
    {
        public GooglePage newGooglePage = new GooglePage();
        public string seacrhName = "Minsk";

        [SetUp]
        public void Setup()
        {
            newGooglePage.InitGooglePage();
        }

        [Test]
        public void TestSearch()
        {
            newGooglePage.SetSearchVaue(seacrhName);
            Assert.IsTrue(newGooglePage.IsResultPresent(seacrhName));
        }

        [TearDown]
        public void EndTest()
        {
            newGooglePage.GetDriver().Quit();
        }
    }
}