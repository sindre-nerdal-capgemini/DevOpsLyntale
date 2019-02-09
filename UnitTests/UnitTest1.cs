using DevOpsLyntale.Controllers;
using NUnit.Framework;
namespace Tests
{
    public class Tests
    {
        private ValuesController _controller;
        [SetUp]
        public void Setup()
        {
            _controller = new ValuesController();
        }

        [Test]
        public void Test_Get_Does_Not_Contain_HitsForKidz()
        {
            var result = _controller.Get();

            Assert.That(result.Value, Has.Exactly(0).EqualTo("HitsForKidz"));
        }
    }
}