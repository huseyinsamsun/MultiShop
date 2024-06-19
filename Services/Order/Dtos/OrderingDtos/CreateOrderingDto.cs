using System;
using GlobalAuto.Order.Entities;

namespace GlobalAuto.Order.Dtos.OrderingDtos
{
	public class CreateOrderingDto
	{
       
        public string UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

