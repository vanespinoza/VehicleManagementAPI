using AutoMapper;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Dto.Request;
using VehicleManagementAPI.Dto.Response;
using VehicleManagementAPI.Entities;

namespace VehicleManagementAPI.Services.Profiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            CreateMap<VehicleDtoRequest, Vehicle>();

            CreateMap<Vehicle, VehicleDtoResponse>();
        }
    }
}
