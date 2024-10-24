using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Domain.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();

            builder.HasOne(d => d.Company) 
                   .WithMany(c => c.Departments)
                   .HasForeignKey(d => d.CompanyId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
