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
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<ICollection<BrandDtoResponse>>> ListAsync(string? filter)
        {
            var response = new BaseResponseGeneric<ICollection<BrandDtoResponse>>();
            try
            {
                var collection = await _repository.ListAsync(filter);

                response.Data = _mapper.Map<ICollection<BrandDtoResponse>>(collection);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<BaseResponseGeneric<BrandDtoResponse>> GetByIdAsync(string id)
        {
            var response = new BaseResponseGeneric<BrandDtoResponse>();
            try
            {
                var entity = await _repository.GetByIdAsync(id);

                response.Data = _mapper.Map<BrandDtoResponse>(entity);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        public async Task<BaseResponseGeneric<string>> CreateAsync(BrandDtoRequest request)
        {
            var response = new BaseResponseGeneric<string>();
            try
            {
                response.Data = await _repository.CreateAsync(_mapper.Map<Brand>(request));
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<BaseResponse> UpdateAsync(string id, BrandDtoRequest request)
        {
            var response = new BaseResponse();

            try
            {
                var genre = await _repository.GetByIdAsync(id);

                if (genre == null)
                {
                    response.Success = false;
                    return response;
                }

                _mapper.Map(request, genre);

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
