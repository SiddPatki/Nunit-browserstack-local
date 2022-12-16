using NUnit.Framework;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace BrowserStack
{
  [TestFixture("local", "chrome")]
  public class LocalTest : BrowserStackNUnitTest
  {
    public LocalTest(string profile, string environment) : base(profile, environment) { }

    [Test]
    public void HealthCheck()
    {
      driver.Navigate().GoToUrl("http://localhost:45454/");
      Assert.IsTrue(Regex.IsMatch(driver.Title, "BrowserStack Local", RegexOptions.IgnoreCase));
    }
  }
}
