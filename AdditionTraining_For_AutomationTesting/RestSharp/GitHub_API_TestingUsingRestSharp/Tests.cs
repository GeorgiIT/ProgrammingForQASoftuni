using NUnit.Framework;
using RestSharp;
using System.Net;

namespace GitHub_API_TestingUsingRestSharp
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_GitHubAPI_GetIssuesByRepo()
        {
            // Arrange
            var client = new RestClient("https://api.github.com/repos/testnakov/test-nakov-repo/issues"); // Works when I try to find sppecific, but I can take all of the comments...

            var request = new RestRequest();


            // Act
            var response = client.Execute(request);
            Console.WriteLine(response.Content); // Output the response body for debugging

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.ContentType, Does.StartWith("application/json"));
        }
    }
}
