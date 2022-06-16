using AppNet.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ModelConfiguration
{
    public class EmployeeConfiguration: IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e=>e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Salary).HasColumnType("decimal(9,2)");
        }
    }
}
