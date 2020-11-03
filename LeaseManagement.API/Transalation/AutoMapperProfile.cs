using AutoMapper;
using LeaseManagement.ClientModels;
using LeaseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaseManagement.API.Transalation
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaseViewModel,LeaseModel>()
                .ForMember(dest => dest.appartment, opt => opt.MapFrom(src => src.Appartment_Other))
                .ForMember(dest => dest.city, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.deliveryfee, opt => opt.MapFrom(src => src.Delivery_Fee))
                .ForMember(dest => dest.state, opt => opt.MapFrom(src => src.State))
                .ForMember(dest => dest.streetaddress, opt => opt.MapFrom(src => src.Street_Address))
                .ForMember(dest => dest.term, opt => opt.MapFrom(src => src.Term))
                .ForMember(dest => dest.zipcode, opt => opt.MapFrom(src => src.Zip_Code))
                ;
        }
    }
}
