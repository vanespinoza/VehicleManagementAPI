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
    public interface IBrandService
    {
        Task<BaseResponseGeneric<ICollection<BrandDtoResponse>>> ListAsync(string? filter);
        Task<BaseResponseGeneric<BrandDtoResponse>> GetByIdAsync(string id);
        Task<BaseResponseGeneric<string>> CreateAsync(BrandDtoRequest request);
        Task<BaseResponse> UpdateAsync(string id, BrandDtoRequest request);
        Task<BaseResponse> DeleteAsync(string id);
    }
}
