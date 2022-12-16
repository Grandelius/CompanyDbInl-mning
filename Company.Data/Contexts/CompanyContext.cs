using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Contexts
{
    public class CompanyContext: DbContext
    {
        public DbSet<_Company> Companies => Set<_Company>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Title> Titles => Set<Title>();
        public DbSet<EmployeeTitle> EmployeeTitles => Set<EmployeeTitle>();
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EmployeeTitle>().HasKey(et =>
            new {et.TitleId, et.EmployeeId});

            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var companies = new List<_Company>
            {
                new _Company
                {
                Id = 1,
                Name = "Hugos Bilar AB",
                OrganisationNumber = "1234567890"
                }

            };
            builder.Entity<_Company>().HasData(companies);

            var departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    CompanyId = 1,
                    Name = "HR"
                },
                new Department
                {
                    Id = 2,
                    CompanyId = 1,
                    Name = "Sales"
                },
                new Department
                {
                    Id = 3,
                    CompanyId = 1,
                    Name = "Support"
                },
                new Department
                {
                    Id = 4,
                    CompanyId = 1,
                    Name = "Distribution"
                },
                new Department
                {
                    Id = 5,
                    CompanyId = 1,
                    Name = "Marketing"
                }
            };
            builder.Entity<Department>().HasData(departments);

            var titles = new List<Title>
            {
                new(){Id = 1, Name = "Manager"},
                new(){Id = 2, Name = "Chief Sales Officer"},
                new(){Id = 3, Name = "Chief Support Officer"},
                new(){Id = 4, Name = "Chief Distribution Officer"},
                new(){Id = 5, Name = "Chief Marketing Officer"},
                new(){Id = 6, Name = "Sales Officer"},
                new(){Id = 7, Name = "Support Officer"},
                new(){Id = 8, Name = "Distribution Officer"},
                new(){Id = 9, Name = "Marketing Officer"},
                new(){Id = 10, Name = "HR Officer"}
            };
            builder.Entity<Title>().HasData(titles);

            var employees = new List<Employee>
            {
                new(){Id = 1, DepartmentId = 1, FirstName = "Mathilda", LastName = "Ljung", Salary = 60000.00m, IsUnionMember = false},
                new(){Id = 2, DepartmentId = 2, FirstName = "Jonatan", LastName = "Grandelius", Salary = 55000.00m, IsUnionMember = true},
                new(){Id = 3, DepartmentId = 3, FirstName = "hugo", LastName = "Grandelius", Salary = 50000.00m, IsUnionMember = false },
                new(){Id = 4, DepartmentId = 4, FirstName = "John", LastName = "Anderson", Salary = 50000.00m, IsUnionMember = true },
                new(){Id = 5, DepartmentId = 5, FirstName = "Eric", LastName = "Johnson", Salary = 50000.00m, IsUnionMember = true },
                new(){Id = 6, DepartmentId = 1, FirstName = "Kerstin", LastName = "Nilsson", Salary = 45000.00m, IsUnionMember = false },
                new(){Id = 7, DepartmentId = 2, FirstName = "Frida", LastName = "Grandelius", Salary = 35000.00m, IsUnionMember = true },
                new(){Id = 8, DepartmentId = 3, FirstName = "Sofie", LastName = "Johansson", Salary = 30000.00m, IsUnionMember = false },
                new(){Id = 9, DepartmentId = 4, FirstName = "Fredrik", LastName = "Ericson", Salary = 35000.00m, IsUnionMember = true },
                new(){Id = 10, DepartmentId = 5, FirstName = "Annelee", LastName = "Johanson", Salary = 30000.00m, IsUnionMember = true },
                new(){Id = 11, DepartmentId = 1, FirstName = "Erik", LastName = "Nilsson", Salary = 10000.00m, IsUnionMember = true },
            };
            builder.Entity<Employee>().HasData(employees);

            var employeeTitles = new List<EmployeeTitle>
            {
                new(){EmployeeId = 1, TitleId = 1},
                new(){EmployeeId = 1, TitleId = 10},
                new(){EmployeeId = 2, TitleId = 2},
                new(){EmployeeId = 3, TitleId = 3},
                new(){EmployeeId = 4, TitleId = 4},
                new(){EmployeeId = 5, TitleId = 5},
                new(){EmployeeId = 6, TitleId = 10},
                new(){EmployeeId = 7, TitleId = 6},
                new(){EmployeeId = 8, TitleId = 7},
                new(){EmployeeId = 9, TitleId = 8},
                new(){EmployeeId = 10, TitleId = 9},

            };
            builder.Entity<EmployeeTitle>().HasData(employeeTitles);

        }
    }
}
