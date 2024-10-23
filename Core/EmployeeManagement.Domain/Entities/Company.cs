using EmployeeManagement.Domain.Entities.Common;

namespace EmployeeManagement.Domain.Entities
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
