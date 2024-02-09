using System.Net;
using FluentAssertions;
using Restful_Booker.requests;
using RestSharp;

namespace Restful_Booker.tests
{
    public class RestfulBookerApiTests
    {
        readonly RestfulBookerApiRequest request = new();
        [Test]
        public void GetAllBookings()
        {
            RestResponse restResponse = request.GetAllBookings();
            restResponse.Should().NotBeNull();
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}