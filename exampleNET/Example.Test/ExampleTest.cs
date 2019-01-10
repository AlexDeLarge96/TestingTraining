using exampleNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace ExampleTest
{
    [TestClass]
    public class ExampleTest
    {
        private Example example;

        [TestMethod]
        public void Test_Add_ExpectingEquals()
        {
            //Setup
            example = new Example(new Http());

            //Perform Test
            int result = example.Add(1, 2);

            //Verify
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void Test_Add_ExpectingNotEquals()
        {
            //Setup
            example = new Example(new Http());

            //Perform Test
            int result = example.Add(2, 2);

            //Verify
            Assert.AreNotEqual(5, result);

        }

        [TestMethod]
        public void Test_GetTitle()
        {
            //Setup
            string JsonBaseTest = "{\"userId\": 1,\"id\": 1,\"title\": \"fake title for test\",\"completed\": false}";
            Mock<Http> mockHttp = new Mock<Http>();
            mockHttp.Setup(client => client.GetData(It.IsAny<string>())).Returns(Task.FromResult(JsonBaseTest));
            example = new Example(mockHttp.Object);

            //Perform Test
            string result = example.GetTitle();

            //Verify
            Assert.AreEqual("FAKE TITLE FOR TEST", result);
        }
    }
}
