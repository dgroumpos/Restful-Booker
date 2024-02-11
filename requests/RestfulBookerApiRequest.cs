using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Restful_Booker.Entities;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Restful_Booker.requests
{
    public class RestfulBookerApiRequest
    {
        public string BaseUrl { get; } = "https://restful-booker.herokuapp.com/booking";

        RestClient client;

        public RestfulBookerApiRequest()
        {
            client = new(BaseUrl);
        }

        public RestResponse GetAllBookings()
        {
            RestRequest restRequest = new(BaseUrl, Method.Get);
            RestResponse restResponse = client.Execute<RestRequest>(restRequest);
            return restResponse;
        }

        public RestResponse PostBooking()
        {
            var body = BuildBodyRequest();
            RestRequest restRequest = new(BaseUrl, Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddBody(body, ContentType.Json);
            RestResponse restResponse = client.Execute<RestRequest>(restRequest);

            return restResponse;
        }

        public Booking BuildBodyRequest()
        {
            return new()
            {
                FirstName = "Jim",
                LastName = "Brown",
                TotalPrice = 111,
                DepositPaid = true,
                BookingDates = new(){Checkin = "2024-01-01", Checkout = "2024-01-06"},
                AdditionalNeeds = "Breakfast"
            };

        }
    }
}