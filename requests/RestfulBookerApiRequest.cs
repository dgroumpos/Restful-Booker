using RestSharp;

namespace Restful_Booker.requests
{
    public class RestfulBookerApiRequest
    {
        readonly string baseUrl = "https://restful-booker.herokuapp.com/booking";

        public string BaseUrl => baseUrl;
        readonly RestClient client;

        public RestfulBookerApiRequest()
        {
            client = new(baseUrl);
        }

        public RestResponse GetAllBookings()
        {
            RestRequest restRequest = new(baseUrl, Method.Get);
            RestResponse restResponse = client.Execute<RestRequest>(restRequest);
            return restResponse;
        }
    }
}