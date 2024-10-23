namespace EmployeeManagement.Application.Dtos.EmployeeDtos
{
    public class EmployeeFilterDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? DepartmentName { get; set; }
        public string? CompanyName { get; set; }
        public int? DepartmentId { get; set; }
        public int? CompanyId { get; set; }
        public int PageNumber { get; set; } 
        public int PageSize { get; set; }
    }
}
