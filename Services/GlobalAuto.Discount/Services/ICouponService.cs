using System;
using GlobalAuto.Discount.Dtos.CouponDtos;

namespace GlobalAuto.Discount.Services
{
	public interface ICouponService
	{
        Task<List<ResultCouponDto>> GetAllCouponAsync();
        Task CreateCouponAsync(CreateCouponDto createCouponDto);
        Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);
        Task DeleteCouponAsync(string id);
        Task<GetByIdCouponDto> GetByIdCouponAsync(string id);
    }
}

