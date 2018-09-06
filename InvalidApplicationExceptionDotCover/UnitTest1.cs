using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TestLibrary;

namespace InvalidApplicationExceptionDotCover
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var repository = new FooRepository();

            IEnumerable<string> testAgaints = new List<string>
            {
                "30 minutes",
                "60 minutes"
            };

            Assert.That(
                repository.GetTimeUnits().Select(s => s.Text),
                Is.EquivalentTo(testAgaints));
        }
    }
}
