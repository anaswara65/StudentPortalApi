﻿using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Gender, GenderDTO>().ReverseMap();
            CreateMap<Address, AddressDTO>().ReverseMap();
        }
    }
}
