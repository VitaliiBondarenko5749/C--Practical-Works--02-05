﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Seeding;

namespace P01_StudentSystem.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);

            builder.Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode();

            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);

            builder.Property(s => s.Birthday)
                .IsRequired(false);

            builder.HasMany(s => s.HomeworkSubmissions)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId);

            builder.HasData(DataSeeder.Students);
        }
    }
}