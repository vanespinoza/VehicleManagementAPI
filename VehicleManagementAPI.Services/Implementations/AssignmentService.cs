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
using VehicleManagementAPI.Services.Interfaces;

namespace VehicleManagementAPI.Services.Implementations
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _repository;
        private readonly IMapper _mapper;

        public AssignmentService(IAssignmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<ICollection<AssignmentDtoResponse>>> ListAsync(string? filter)
        {
            var response = new BaseResponseGeneric<ICollection<AssignmentDtoResponse>>();
            try
            {
                var collection = await _repository.ListAsync(filter,1,10);
                response.Data = _mapper.Map<ICollection<AssignmentDtoResponse>>(collection.Collection);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<BaseResponseGeneric<AssignmentDtoResponse>> GetByIdAsync(string id)
        {
            var response = new BaseResponseGeneric<AssignmentDtoResponse>();
            try
            {
                var entity = await _repository.GetByIdAsync(id);

                response.Data = _mapper.Map<AssignmentDtoResponse>(entity);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<BaseResponseGeneric<string>> CreateAsync(AssignmentDtoRequest request)
        {
            var response = new BaseResponseGeneric<string>();
            try
            {
                response.Data = await _repository.CreateAsync(_mapper.Map<Assignment>(request));
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<BaseResponse> UpdateAsync(string id, AssignmentDtoRequest request)
        {
            var response = new BaseResponse();

            try
            {
                var entity = await _repository.GetByIdAsync(id);

                if (entity == null)
                {
                    response.Success = false;
                    return response;
                }

                _mapper.Map(request, entity);

                await _repository.UpdateAsync();

                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<BaseResponse> DeleteAsync(string id)
        {
            var response = new BaseResponse();

            try
            {
                await _repository.DeleteAsync(id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}
