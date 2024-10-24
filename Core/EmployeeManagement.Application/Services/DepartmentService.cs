using AutoMapper;
using EmployeeManagement.Application.Dtos.DepartmentDtos;
using EmployeeManagement.Application.Services.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using EmployeeManagement.Domain.Interfaces;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IPaginateRepository<Department> _paginateRepository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRepository,
                              IPaginateRepository<Department> paginateRepository,
                              IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _paginateRepository = paginateRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateDepartmentDto model)
        {
            var mappedData = _mapper.Map<Department>(model);
            await _departmentRepository.AddAsync(mappedData);
            await _departmentRepository.SaveAsync();
        }

        public async Task<List<ResultDepartmentDto>> GetAllAsync()
        {
            var datas = await _departmentRepository.GetAllAsync();
            var mappedDatas = _mapper.Map<List<ResultDepartmentDto>>(datas);

            return mappedDatas;
        }

        public async Task<Paginate<ResultDepartmentDto>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            var datas = await _departmentRepository.GetAllAsync();
            var mappedDatas = _mapper.Map<List<ResultDepartmentDto>>(datas);

            return _paginateRepository.PaginatedData(mappedDatas, pageNumber, pageSize);
        }

        public async Task<ResultDepartmentDto> GetByIdAsync(int id)
        {
            var data = await _departmentRepository.GetByIdAsync(id);

            if (data is null) return null;

            return _mapper.Map<ResultDepartmentDto>(data);
        }

        public async Task<ResultDepartmentDto> GetSingleAsync(Expression<Func<Department, bool>> method)
        {
            var data = await _departmentRepository.GetSingleAsync(method);

            if (data is null) return null;

            return _mapper.Map<ResultDepartmentDto>(data);
        }

        public async Task<List<ResultDepartmentDto>> GetWhereAsync(Expression<Func<Department, bool>> method)
        {
            var datas = await _departmentRepository.GetWhereAsync(method);
            var mappedDatas = _mapper.Map<List<ResultDepartmentDto>>(datas);

            return mappedDatas;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var data = await _departmentRepository.GetByIdAsync(id);

            if (data is null) return false;

            _departmentRepository.Remove(data);
            await _departmentRepository.SaveAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(int id, UpdateDepartmentDto model)
        {
            var data = await _departmentRepository.GetByIdAsync(id);

            if (data is null) return false;

            _mapper.Map(model, data);

            _departmentRepository.Update(data);
            await _departmentRepository.SaveAsync();

            return true;
        }
    }
}
