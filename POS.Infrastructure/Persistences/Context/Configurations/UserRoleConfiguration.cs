﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Context.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(e => e.UserRoleId).HasName("PK__UserRole__3D978A35FD28E6FB");

        builder.HasOne(d => d.BranchOffice).WithMany(p => p.UserRoles)
            .HasForeignKey(d => d.BranchOfficeId)
            .HasConstraintName("FK__UserRoles__Branc__00200768");

        builder.HasOne(d => d.Role).WithMany(p => p.UserRoles)
            .HasForeignKey(d => d.RoleId)
            .HasConstraintName("FK__UserRoles__RoleI__01142BA1");

        builder.HasOne(d => d.User).WithMany(p => p.UserRoles)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("FK__UserRoles__UserI__02084FDA"); throw new NotImplementedException();
    }
}
