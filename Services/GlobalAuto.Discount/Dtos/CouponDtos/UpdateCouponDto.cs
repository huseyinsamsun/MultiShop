﻿using System;
namespace GlobalAuto.Discount.Dtos.CouponDtos
{
	public class UpdateCouponDto
	{
        public string CouponId { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}

