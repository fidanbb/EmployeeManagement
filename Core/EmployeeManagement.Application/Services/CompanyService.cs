using AutoMapper;
using EmployeeManagement.Application.Dtos.CompanyDtos;
using EmployeeManagement.Application.Services.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Helpers.Pagination;
using EmployeeManagement.Domain.Interfaces;
using System.Linq.Expressions;

namespace EmployeeManagement.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IPaginateRepository<Company> _paginateRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, 
                              IPaginateRepository<Company> paginateRepository,
                              IMapper mapper)
        {
            _companyRepository = companyRepository;
            _paginateRepository = paginateRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateCompanyDto model)
        {
            var mappedData = _mapper.Map<Company>(model);
            await _companyRepository.AddAsync(mappedData);
            await _companyRepository.SaveAsync();
        }

        public async Task<List<ResultCompanyDto>> GetAllAsync()
        {
           var datas = await _companyRepository.GetAllAsync();
           var mappedDatas = _mapper.Map<List<ResultCompanyDto>>(datas);

           return mappedDatas;
        }

        public async Task<Paginate<ResultCompanyDto>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
           var datas = await _companyRepository.GetAllAsync();
           var mappedDatas = _mapper.Map<List<ResultCompanyDto>>(datas);

           return _paginateRepository.PaginatedData(mappedDatas,pageNumber,pageSize);

        }

        public async Task<ResultCompanyDto> GetByIdAsync(int id)
        {
           var data = await _companyRepository.GetByIdAsync(id);

           if (data is null) return null;
            
           return _mapper.Map<ResultCompanyDto>(data);
        }

        public async Task<ResultCompanyDto> GetSingleAsync(Expression<Func<Company, bool>> method)
        {
           var data = await _companyRepository.GetSingleAsync(method);

           if (data is null) return null;

           return _mapper.Map<ResultCompanyDto>(data);
        }

        public async Task<List<ResultCompanyDto>> GetWhereAsync(Expression<Func<Company, bool>> method)
        {
           var datas = await _companyRepository.GetWhereAsync(method);
           var mappedDatas = _mapper.Map<List<ResultCompanyDto>>(datas);
           
           return mappedDatas;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var data = await _companyRepository.GetByIdAsync(id);

            if (data is null) return false;

            _companyRepository.Remove(data);
            await _companyRepository.SaveAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(int id, UpdateCompanyDto model)
        {
            var data = await _companyRepository.GetByIdAsync(id);

            if (data is null) return false;

            _mapper.Map(model,data);

            _companyRepository.Update(data);
            await _companyRepository.SaveAsync();

            return true;
        }
    }
}
