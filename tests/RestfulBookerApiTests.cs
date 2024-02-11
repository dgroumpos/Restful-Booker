using System.Net;
using FluentAssertions;
using Restful_Booker.Entities;
using Restful_Booker.requests;
using RestSharp;
using JsonSerializer = System.Text.Json.JsonSerializer;

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

        [Test]
        public void CreateBooking()
        {
            RestResponse restResponse = request.PostBooking();
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            restResponse.Content.Should().NotBeNull();
            var bodyContent = JsonSerializer.Deserialize<BookingResp>(restResponse.Content);  
            restResponse.Content.Should().NotBeNull();
            bodyContent.Id.Should().NotBe(null);
            bodyContent.Booking.FirstName.Should().NotBeNull();
        }
    }
}