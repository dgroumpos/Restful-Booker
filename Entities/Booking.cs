using System.Text.Json.Serialization;

namespace Restful_Booker.Entities
{
    public class Booking
    {
        [JsonPropertyName("bookingid")]
        public int Id { get; set; }
        [JsonPropertyName("firstname")]
        public required string FirstName { get; set; }
        [JsonPropertyName("lastname")]
        public required string LastName { get; set; }
        [JsonPropertyName("totalprice")]
        public int TotalPrice { get; set; }
        [JsonPropertyName("depositpaid")]
        public bool DepositPaid { get; set; }
        [JsonPropertyName("bookingdates")]
        public BookingDates BookingDates { get; set; }
        
        [JsonPropertyName("additionalneeds")]
        public string? AdditionalNeeds { get; set; }
    }

    public class BookingDates
    {
        [JsonPropertyName("checkin")]
        public string Checkin { get; set; }
        [JsonPropertyName("checkout")]
        public string Checkout { get; set; }
    }

    public class BookingResp
    {
        [JsonPropertyName("bookingid")]
        public int Id { get; set; }
        [JsonPropertyName("booking")]
        public Booking Booking { get; set; }
    }
}