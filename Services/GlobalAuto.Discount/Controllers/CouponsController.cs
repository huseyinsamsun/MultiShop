using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalAuto.Discount.Dtos.CouponDtos;
using GlobalAuto.Discount.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlobalAuto.Discount.Controllers
{
  
        [Route("api/[controller]")]
        [ApiController]
        public class CouponsController : ControllerBase
        {
            private readonly ICouponService _couponService;
            public CouponsController(ICouponService couponService)
            {
            _couponService = couponService;
            }
            [HttpGet]
            public async Task<IActionResult> CouponList()
            {
                var values = await _couponService.GetAllCouponAsync();
                return Ok(values);
            }
            [HttpGet("{id}")]
            public async Task<IActionResult> GetCouponById(string id)
            {
                var values = await _couponService.GetByIdCouponAsync(id);
                return Ok(values);
            }
            [HttpPost]
            public async Task<IActionResult> CreateCoupon(CreateCouponDto createCouponDto)
            {
                await _couponService.CreateCouponAsync(createCouponDto);
                return Ok("Kupon Başarı Ile Eklendi");
            }
            [HttpDelete]
            public async Task<IActionResult> DeleteCoupon(string id)
            {
                await _couponService.DeleteCouponAsync(id);
                return Ok("Kupon Başarı İle Silindi");

            }
            [HttpPut]
            public async Task<IActionResult> UpdateCoupon(UpdateCouponDto updateCouponDto)
            {
                await _couponService.UpdateCouponAsync(updateCouponDto);
                return Ok("Kupon Başarı İle Güncellendi");

            }

        }
    }


