﻿using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Student
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("varchar(30)");
            builder.HasOne<StudentDetail>(s => s.StudentDetail).WithOne(sd => sd.Student)
                .HasForeignKey<StudentDetail>(sd => sd.StudentID);
        }
    }
}
