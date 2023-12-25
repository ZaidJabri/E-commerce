namespace Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public int? StreetNumber { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

    }
}
