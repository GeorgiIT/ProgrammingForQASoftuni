using Eventmi.Core.Models.Event;
using RestSharp;

namespace EventControllerTests
{
    [TestFixture]
    public class EventControllerTests
    {
        private RestClient _client;
        private const string baseUrl = @"https://localhost:7236";
        
        [SetUp]
        public void Setup()
        {
            _client = new RestClient(baseUrl);
        }

        [Test]
        public void GetAllEvents_ReturnsSuccessStatusCode()
        {
            //Arrange
            var request = new RestRequest("/Event/All", Method.Get);
            //Act
            var response = _client.Get(request);
            //Assert
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
        }

        [Test]
        public void Add_PostRequest_AddsEventAndRedirects()
        {

            var newEvent = new EventFormModel
            {
                Name = "TEST -> New Event adding",
                Start = new DateTime(2024, 05, 14, 10, 0,0),
                End = new DateTime(2024,05,14,12,0,0),
                Place = "Burgas NHK"
            };

            var request = new RestRequest("Event/All", Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Name", newEvent.Name);
            request.AddParameter("Start", newEvent.Start.ToString("MM/dd/yyyy hh:mm tt"));
            request.AddParameter("End", newEvent.End.ToString("MM/dd/yyyy hh:mm tt"));
            request.AddParameter("Place", newEvent.Place);
            var response = _client.Post(request);


            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));

        }

    }
}