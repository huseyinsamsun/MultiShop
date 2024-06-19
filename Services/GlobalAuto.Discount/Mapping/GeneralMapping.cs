using System;
using AutoMapper;
using GlobalAuto.Discount.Dtos.CouponDtos;
using GlobalAuto.Discount.Entities;

namespace GlobalAuto.Discount.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping()
		{
            CreateMap<Coupon, ResultCouponDto>().ReverseMap();
            CreateMap<Coupon, CreateCouponDto>().ReverseMap();
            CreateMap<Coupon, GetByIdCouponDto>().ReverseMap();
            CreateMap<Coupon, UpdateCouponDto>().ReverseMap();

        }
    }
}

