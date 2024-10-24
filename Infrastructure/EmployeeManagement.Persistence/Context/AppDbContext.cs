using EmployeeManagement.Domain.Configurations;
using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EmployeeManagement.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().HasData(
                  new Company { Id = 1, Name = "Pasha Bank" },
                  new Company { Id = 2, Name = "Socar" },
                  new Company { Id = 3, Name = "Azerenergy" },
                  new Company { Id = 4, Name = "AzerGold" },
                  new Company { Id = 5, Name = "Azersun Holding" },
                  new Company { Id = 6, Name = "Azercell" });


            modelBuilder.Entity<Department>().HasData(
                  new Department { Id = 1,  Name = "IT", CompanyId = 1 },
                  new Department { Id = 2,  Name = "HR", CompanyId = 1 },
                  new Department { Id = 3,  Name = "Marketing", CompanyId = 2 },
                  new Department { Id = 4,  Name = "Finance", CompanyId = 2 },
                  new Department { Id = 5,  Name = "R&D", CompanyId = 3 },
                  new Department { Id = 6,  Name = "Sales", CompanyId = 3 },
                  new Department { Id = 7,  Name = "Engineering", CompanyId = 4 },
                  new Department { Id = 8,  Name = "Production", CompanyId = 4 },
                  new Department { Id = 9,  Name = "Culinary", CompanyId = 5 },
                  new Department { Id = 10, Name = "Supply Chain", CompanyId = 5 },
                  new Department { Id = 11, Name = "Customer Service", CompanyId = 6 },
                  new Department { Id = 12, Name = "Business Development", CompanyId = 6 });


            modelBuilder.Entity<Employee>().HasData(
                 new Employee { Id = 1,  Name = "Anar",  Surname = "Hüseynov", DepartmentId = 1, BirthDate = new DateTime(1985, 5, 12)},
                 new Employee { Id = 2,  Name = "Aysel", Surname = "Quliyeva", DepartmentId = 2, BirthDate = new DateTime(1990, 3, 24) },
                 new Employee { Id = 3,  Name = "Murad", Surname = "Əliyev", DepartmentId = 3, BirthDate = new DateTime(2000, 7, 14)},
                 new Employee { Id = 4,  Name = "Nigar", Surname = "Səfərova", DepartmentId = 1, BirthDate = new DateTime(1995, 8, 19) },
                 new Employee { Id = 5,  Name = "Elvin", Surname = "İsmayılov", DepartmentId = 8, BirthDate = new DateTime(1992, 4, 11) },
                 new Employee { Id = 6,  Name = "Leyla", Surname = "Əliyeva", DepartmentId = 2, BirthDate = new DateTime(1996, 6, 17)},
                 new Employee { Id = 7,  Name = "Rəşad", Surname = "Əhmədov", DepartmentId = 3, BirthDate = new DateTime(1987, 10, 5) },
                 new Employee { Id = 8,  Name = "Günel", Surname = "Əliyeva", DepartmentId = 4, BirthDate = new DateTime(1993, 9, 25)},
                 new Employee { Id = 9,  Name = "Vüsal", Surname = "Əkbərov", DepartmentId = 5, BirthDate = new DateTime(1984, 12, 1) },
                 new Employee { Id = 10, Name = "İlqar", Surname = "Məmmədov", DepartmentId = 6, BirthDate = new DateTime(1989, 11, 30) },
                 new Employee { Id = 11, Name = "Sevinc", Surname = "Rzayeva", DepartmentId = 7, BirthDate = new DateTime(1991, 1, 14)},
                 new Employee { Id = 12, Name = "Taleh", Surname = "Qasımov", DepartmentId = 3, BirthDate = new DateTime(1983, 2, 2) },
                 new Employee { Id = 13, Name = "Zaur", Surname = "Abdullayev", DepartmentId = 11, BirthDate = new DateTime(1994, 3, 8) },
                 new Employee { Id = 14, Name = "Kamran", Surname = "Nəsibov", DepartmentId = 4, BirthDate = new DateTime(1986, 4, 9) },
                 new Employee { Id = 15, Name = "Elçin", Surname = "Nəzərov", DepartmentId = 12, BirthDate = new DateTime(1992, 5, 6)},
                 new Employee { Id = 16, Name = "Aynur", Surname = "Həsənova", DepartmentId = 2, BirthDate = new DateTime(1989, 6, 7) },
                 new Employee { Id = 17, Name = "Fuad", Surname = "Babayev", DepartmentId = 3, BirthDate = new DateTime(1985, 7, 18) },
                 new Employee { Id = 18, Name = "Namiq", Surname = "Əliyev", DepartmentId = 5, BirthDate = new DateTime(1982, 8, 11)}, 
                 new Employee { Id = 19, Name = "Orxan", Surname = "Hüseynov", DepartmentId = 4, BirthDate = new DateTime(1993, 9, 14)},
                 new Employee { Id = 20, Name = "Rəna", Surname = "Mustafayeva", DepartmentId = 1, BirthDate = new DateTime(1995, 10, 10) },
                 new Employee { Id = 22, Name = "Şəhriyar", Surname = "Həsənov", DepartmentId = 10, BirthDate = new DateTime(1984, 12, 21) },
                 new Employee { Id = 23, Name = "Ülviyyə", Surname = "İsmayılova", DepartmentId = 4, BirthDate = new DateTime(1988, 1, 30) },
                 new Employee { Id = 24, Name = "Toğrul", Surname = "Hüseynov", DepartmentId = 5, BirthDate = new DateTime(1994, 2, 22) },
                 new Employee { Id = 25, Name = "Rəşad", Surname = "Bayramov", DepartmentId = 1, BirthDate = new DateTime(1986, 3, 15) },
                 new Employee { Id = 26, Name = "Kənan", Surname = "Cəfərov", DepartmentId = 2, BirthDate = new DateTime(1991, 4, 18) },
                 new Employee { Id = 27, Name = "Zəka", Surname = "Mustafayev", DepartmentId = 3, BirthDate = new DateTime(1987, 5, 26) },
                 new Employee { Id = 28, Name = "Fərid", Surname = "Xəlilov", DepartmentId = 4, BirthDate = new DateTime(1993, 6, 19) },
                 new Employee { Id = 29, Name = "Eldar", Surname = "Salmanov", DepartmentId = 9, BirthDate = new DateTime(1985, 7, 7)},
                 new Employee { Id = 30, Name = "Sabir", Surname = "Babayev", DepartmentId = 1, BirthDate = new DateTime(1992, 8, 16) });



        }

    }
}
