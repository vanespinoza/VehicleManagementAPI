using AutoMapper;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Dto.Request;
using VehicleManagementAPI.Dto.Response;
using VehicleManagementAPI.Entities;

namespace VehicleManagementAPI.Services.Profiles
{
    public class AssignmentProfile : Profile
    {

        public AssignmentProfile()
        {
            CreateMap<AssignmentDtoRequest, Assignment>();

            CreateMap<AssignmentInfo, AssignmentDtoResponse>()
         .ForMember(destino => destino.VehicleInfo, origen => origen.MapFrom(p => p.BrandVehicle + " " + p.ModelVehicle))
         .ForMember(destino => destino.DriverFullName, origen => origen.MapFrom(p => p.DriverName))
         .ForMember(destino => destino.StartDate, origen => origen.MapFrom(p => p.StartDate))
         .ForMember(destino => destino.EndDate, origen => origen.MapFrom(p => p.EndDate))
         .ForMember(destino => destino.Amount, origen => origen.MapFrom(p => p.Amount));

            CreateMap<Assignment, AssignmentDtoResponse>();

        }
    }
}
