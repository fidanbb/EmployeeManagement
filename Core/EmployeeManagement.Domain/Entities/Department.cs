using EmployeeManagement.Domain.Entities.Common;

namespace EmployeeManagement.Domain.Entities
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
