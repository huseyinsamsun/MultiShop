using System;
namespace GlobalAuto.Order.Dtos.AddressDtos
{
	public class ResultAddressDto
	{
        public string AddressId { get; set; }
        public string UserId { get; set; }
        public string Distinct { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}

