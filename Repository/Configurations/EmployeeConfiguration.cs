using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = new Guid("ca761232-ed42-11ce-bacd-00aa0057b323"),
                    Name = "Mr.Ade",
                    Age = 30,
                    Position = "Software dev.",
                    CompanyId = new Guid("ca761332-ed42-11ce-bacd-00aa0057b223")


                },
                new Employee
                {
                    Id = new Guid("ca761232-ed42-11ce-bacd-00aa0057b123"),
                    Name = "Mr. Adams",
                    Age = 25,
                    Position = "Backend Engineer",
                    CompanyId = new Guid("ca761332-ed42-11ce-bacd-00aa0057b223"),
                },
                new Employee
                {
                    Id = new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"),
                    Name = "Kane Miller",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new Guid("ca761233-ed42-11ce-bacd-00aa0057b223")
                });

        }
    }
}
