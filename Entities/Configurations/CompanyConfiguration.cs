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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = new Guid("ca761332-ed42-11ce-bacd-00aa0057b223"),
                    Name = "IT_Solutions ltd.",
                    Address = "My address",
                    Country = "My Country"

                },
                new Company
                {
                    Id=new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"),
                    Name = "Internal Bank ltd",
                    Address= "My 2nd Address",
                    Country= "My country"
                }) ;
          
        }
    }
}
