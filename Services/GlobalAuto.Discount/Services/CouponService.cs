using System;
using AutoMapper;
using GlobalAuto.Discount.Dtos.CouponDtos;
using GlobalAuto.Discount.Entities;
using GlobalAuto.Discount.Settings;
using MongoDB.Driver;

namespace GlobalAuto.Discount.Services
{
    public class CouponService : ICouponService
    {
        private readonly IMongoCollection<Coupon> _couponCollection;
        private readonly IMapper _mapper;
        public CouponService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _couponCollection = database.GetCollection<Coupon>(_databaseSettings.CouponCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            var value = _mapper.Map<Coupon>(createCouponDto);
            await _couponCollection.InsertOneAsync(value);
        }

        public async Task DeleteCouponAsync(string id)
        {
            await _couponCollection.DeleteOneAsync(x => x.CouponId == id);
        }

        public async Task<List<ResultCouponDto>> GetAllCouponAsync()
        {
            var values = await _couponCollection.Find(x => true).ToListAsync();
            return (_mapper.Map<List<ResultCouponDto>>(values));
        }

        public async Task<GetByIdCouponDto> GetByIdCouponAsync(string id)
        {
            var values = await _couponCollection.Find<Coupon>(x => x.CouponId == id).FirstOrDefaultAsync();
            return (_mapper.Map<GetByIdCouponDto>(values));
        }

        public async Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {

            var value = _mapper.Map<Coupon>(updateCouponDto);
            await _couponCollection.FindOneAndReplaceAsync(x => x.CouponId == updateCouponDto.CouponId, value);
        }
    }
}

