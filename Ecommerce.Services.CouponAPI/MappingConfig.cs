﻿using AutoMapper;
using Ecommerce.Services.CouponAPI.Models;
using Ecommerce.Services.CouponAPI.Models.Dto;

namespace Ecommerce.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });

            return mappingConfig;
        }
    }
}
