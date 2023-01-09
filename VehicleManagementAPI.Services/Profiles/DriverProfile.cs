using AutoMapper;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Dto.Request;
using VehicleManagementAPI.Dto.Response;
using VehicleManagementAPI.Entities;

namespace VehicleManagementAPI.Services.Profiles
{
    public class DriverProfile : Profile
    {

        public DriverProfile()
        {
            CreateMap<DriverDtoRequest, Driver>();

            CreateMap<Driver, DriverDtoResponse>();
        }
    }
}
