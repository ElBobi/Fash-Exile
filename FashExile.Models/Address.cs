namespace FashExile.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City {  get; set; }
        public string PostalCode { get; set; }
        public string AddressOne { get; set; }
        public string? AddressTwo { get; set; } = null;
    }
}