using AutoMapper;
using ECommerceAPI.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Dto.Request;
using VehicleManagementAPI.Dto.Response;
using VehicleManagementAPI.Repositories.Interfaces;

namespace VehicleManagementAPI.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<BaseResponseGeneric<ICollection<VehicleDtoResponse>>> ListAsync(string? filter);
        Task<BaseResponseGeneric<VehicleDtoResponse>> GetByIdAsync(string id);
        Task<BaseResponseGeneric<string>> CreateAsync(VehicleDtoRequest request);
        Task<BaseResponse> UpdateAsync(string id, VehicleDtoRequest request);
        Task<BaseResponse> DeleteAsync(string id);
    }
}
