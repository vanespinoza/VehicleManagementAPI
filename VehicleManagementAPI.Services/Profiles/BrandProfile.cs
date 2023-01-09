using AutoMapper;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Dto.Request;
using VehicleManagementAPI.Dto.Response;
using VehicleManagementAPI.Entities;

namespace VehicleManagementAPI.Services.Profiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandDtoRequest, Brand>();

            CreateMap<Brand, BrandDtoResponse>();
        }
    }
}
