using System;
namespace GlobalAuto.Order.Dtos.OrderDetailDtos
{
	public class ResultOrderDetailDto
	{
        public string OrderDetailId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public string OrderingId { get; set; }
    }
}

