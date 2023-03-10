// <auto-generated />
using System;
using Company.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20221216144258_DbUpdates")]
    partial class DbUpdates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            Name = "Support"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 1,
                            Name = "Distribution"
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 1,
                            Name = "Marketing"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsUnionMember")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            FirstName = "Mathilda",
                            IsUnionMember = false,
                            LastName = "Ljung",
                            Salary = 60000.00m
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            FirstName = "Jonatan",
                            IsUnionMember = true,
                            LastName = "Grandelius",
                            Salary = 55000.00m
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            FirstName = "hugo",
                            IsUnionMember = false,
                            LastName = "Grandelius",
                            Salary = 50000.00m
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            FirstName = "John",
                            IsUnionMember = true,
                            LastName = "Anderson",
                            Salary = 50000.00m
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 5,
                            FirstName = "Eric",
                            IsUnionMember = true,
                            LastName = "Johnson",
                            Salary = 50000.00m
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 1,
                            FirstName = "Kerstin",
                            IsUnionMember = false,
                            LastName = "Nilsson",
                            Salary = 45000.00m
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 2,
                            FirstName = "Frida",
                            IsUnionMember = true,
                            LastName = "Grandelius",
                            Salary = 35000.00m
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 3,
                            FirstName = "Sofie",
                            IsUnionMember = false,
                            LastName = "Johansson",
                            Salary = 30000.00m
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 4,
                            FirstName = "Fredrik",
                            IsUnionMember = true,
                            LastName = "Ericson",
                            Salary = 35000.00m
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 5,
                            FirstName = "Annelee",
                            IsUnionMember = true,
                            LastName = "Johanson",
                            Salary = 30000.00m
                        },
                        new
                        {
                            Id = 11,
                            DepartmentId = 1,
                            FirstName = "Erik",
                            IsUnionMember = true,
                            LastName = "Nilsson",
                            Salary = 10000.00m
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.EmployeeTitle", b =>
                {
                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("TitleId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTitles");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            EmployeeId = 1
                        },
                        new
                        {
                            TitleId = 10,
                            EmployeeId = 1
                        },
                        new
                        {
                            TitleId = 2,
                            EmployeeId = 2
                        },
                        new
                        {
                            TitleId = 3,
                            EmployeeId = 3
                        },
                        new
                        {
                            TitleId = 4,
                            EmployeeId = 4
                        },
                        new
                        {
                            TitleId = 5,
                            EmployeeId = 5
                        },
                        new
                        {
                            TitleId = 10,
                            EmployeeId = 6
                        },
                        new
                        {
                            TitleId = 6,
                            EmployeeId = 7
                        },
                        new
                        {
                            TitleId = 7,
                            EmployeeId = 8
                        },
                        new
                        {
                            TitleId = 8,
                            EmployeeId = 9
                        },
                        new
                        {
                            TitleId = 9,
                            EmployeeId = 10
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chief Sales Officer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chief Support Officer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chief Distribution Officer"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chief Marketing Officer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sales Officer"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Support Officer"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Distribution Officer"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Marketing Officer"
                        },
                        new
                        {
                            Id = 10,
                            Name = "HR Officer"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities._Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("OrganisationNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hugos Bilar AB",
                            OrganisationNumber = "1234567890"
                        });
                });

            modelBuilder.Entity("EmployeeTitle", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("TitlesId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId", "TitlesId");

                    b.HasIndex("TitlesId");

                    b.ToTable("EmployeeTitle");
                });

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.HasOne("Company.Data.Entities._Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Employee", null)
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.HasOne("Company.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Company.Data.Entities.EmployeeTitle", b =>
                {
                    b.HasOne("Company.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("EmployeeTitle", b =>
                {
                    b.HasOne("Company.Data.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Title", null)
                        .WithMany()
                        .HasForeignKey("TitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.Navigation("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}
