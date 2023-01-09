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
    public interface IAssignmentService
    {
        Task<BaseResponseGeneric<ICollection<AssignmentDtoResponse>>> ListAsync(string? filter);
        Task<BaseResponseGeneric<AssignmentDtoResponse>> GetByIdAsync(string id);
        Task<BaseResponseGeneric<string>> CreateAsync(AssignmentDtoRequest request);
        Task<BaseResponse> UpdateAsync(string id, AssignmentDtoRequest request);
        Task<BaseResponse> DeleteAsync(string id);
    }
}
