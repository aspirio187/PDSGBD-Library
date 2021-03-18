﻿using AutoMapper;
using Bibliotheque.EntityFramework.Entities;
using Bibliotheque.EntityFramework.Helpers;
using Bibliotheque.EntityFramework.Services.Authentication;
using Bibliotheque.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.UI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserForCreationRecord, UserEntity>()
                .ForMember(
                    dest => dest.NormalizedEmail,
                    opt => opt.MapFrom(src => src.Email.ToUpper()))
                .ForMember(
                    dest => dest.Password,
                    opt => opt.MapFrom(
                        src => HashingHelper.HashUsingPbkdf2(src.Password, src.Email)))
                .ForMember(
                    dest => dest.BirthDate,
                    opt => opt.MapFrom(src => src.BirthDate));

            CreateMap<UserConnectionRecord, LoginRequest>();

            CreateMap<UserForUpdateModel, UserEntity>()
                .ForMember(
                    dest => dest.Gender,
                    opt => opt.MapFrom(
                        src => src.Gender.Name))
                .ForMember(
                    dest => dest.BirthDate,
                    opt => opt.MapFrom(
                        src => (DateTimeOffset)src.DateBirth));

            CreateMap<UserEntity, UserForUpdateModel>()
                .ForMember(
                    dest => dest.Gender,
                    opt => opt.MapFrom(
                        src => new GenderRecord(src.Gender)))
                .ForMember(
                    dest => dest.DateBirth,
                    opt => opt.MapFrom(
                        src => src.BirthDate.DateTime));
        }
    }
}
