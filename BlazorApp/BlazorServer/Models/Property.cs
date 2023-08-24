using System;
namespace BlazorServer.Models
{
	public class Property
	{
		public int PropertyID { get; set; }
        public string? PropertyName { get; set; }
        public int Price { get; set; }
        public int Sqft { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public string HomeType { get; set; }
        public int YearBuilt { get; set; }
        public string DateListed { get; set; }
        public string Description { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string ApartmentUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    }
}
