using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Domain.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();

            builder.Property(a => a.Surname).HasMaxLength(100).IsRequired();

            builder.Property(a => a.BirthDate).IsRequired();

            builder.HasOne(e => e.Department) 
                   .WithMany(d => d.Employees)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
