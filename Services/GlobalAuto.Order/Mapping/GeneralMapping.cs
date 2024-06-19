using System;
using AutoMapper;
using GlobalAuto.Order.Dtos.AddressDtos;
using GlobalAuto.Order.Dtos.OrderDetailDtos;
using GlobalAuto.Order.Dtos.OrderingDtos;
using GlobalAuto.Order.Entities;

namespace GlobalAuto.Order.Mapping
{
	
        public class GeneralMapping : Profile
        {
            public GeneralMapping()
            {
                CreateMap<Address, ResultAddressDto>().ReverseMap();
                CreateMap<Address, CreateAddressDto>().ReverseMap();
                CreateMap<Address, GetByIdAddressDto>().ReverseMap();
                CreateMap<Address, UpdateAddressDto>().ReverseMap();


                CreateMap<OrderDetail, ResultOrderDetailDto>().ReverseMap();
                CreateMap<OrderDetail, CreateOrderDetailDto>().ReverseMap();
                CreateMap<OrderDetail, GetByIdOrderDetailDto>().ReverseMap();
                CreateMap<OrderDetail, UpdateOrderDetailDto>().ReverseMap();

                CreateMap<Ordering, ResultOrderingDto>().ReverseMap();
                CreateMap<Ordering, CreateOrderingDto>().ReverseMap();
                CreateMap<Ordering, GetByIdOrderingDto>().ReverseMap();
                CreateMap<Ordering, UpdateOrderingDto>().ReverseMap();

        }
        }
    
}

