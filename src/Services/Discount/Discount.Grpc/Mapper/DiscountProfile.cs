﻿using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            // first come from our entities
            // second. coming from Discount.grpc namespace, which generated by visual studio

            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}