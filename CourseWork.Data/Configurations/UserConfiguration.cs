﻿using CourseWork.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseWork.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(userModel => userModel.Id).HasName("user_pkey");
            builder.Property(userModel => userModel.Id).HasColumnName("user_id");
            builder.Property(userModel => userModel.FirstName).HasColumnName("user_first_name").HasMaxLength(32);
            builder.Property(userModel => userModel.LastName).HasColumnName("user_last_name").HasMaxLength(32);
            builder.Property(userModel => userModel.Role).HasColumnName("user_role");
        }
    }
}