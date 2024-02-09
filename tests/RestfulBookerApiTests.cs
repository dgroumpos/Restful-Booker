using System.Net;
using FluentAssertions;
using RestSharp;

namespace Restful_Booker.tests
{
    public class RestfulBookerApiTests
    {
        [Test]
        public void GetAllBookings()
        {
            var baseUrl = "https://restful-booker.herokuapp.com/booking";
            RestClient client = new(baseUrl);
            RestRequest restRequest = new(baseUrl, Method.Get);
            RestResponse restResponse = client.Execute<RestRequest>(restRequest);
            restResponse.Should().NotBeNull();
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}