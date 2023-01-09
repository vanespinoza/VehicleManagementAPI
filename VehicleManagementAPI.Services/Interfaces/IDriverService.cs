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
    public interface IDriverService
    {
        Task<BaseResponseGeneric<ICollection<DriverDtoResponse>>> ListAsync(string? filter);
        Task<BaseResponseGeneric<DriverDtoResponse>> GetByIdAsync(string id);
        Task<BaseResponseGeneric<string>> CreateAsync(DriverDtoRequest request);
        Task<BaseResponse> UpdateAsync(string id, DriverDtoRequest request);
        Task<BaseResponse> DeleteAsync(string id);
    }
}
