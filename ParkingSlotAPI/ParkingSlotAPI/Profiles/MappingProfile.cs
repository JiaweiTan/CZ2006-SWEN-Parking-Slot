﻿using AutoMapper;
using ParkingSlotAPI.Entities;
using ParkingSlotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSlotAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Carpark, CarparkDto>();
        }
    }
}