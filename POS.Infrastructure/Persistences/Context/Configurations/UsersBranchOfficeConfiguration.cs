using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Context.Configurations;

public class UsersBranchOfficeConfiguration : IEntityTypeConfiguration<UsersBranchOffice>
{
    public void Configure(EntityTypeBuilder<UsersBranchOffice> builder)
    {
        builder.HasKey(e => e.UserBranchOfficeId).HasName("PK__UsersBra__7D1E804A50359C1C");

        builder.HasOne(d => d.BranchOffice).WithMany(p => p.UsersBranchOffices)
            .HasForeignKey(d => d.BranchOfficeId)
            .HasConstraintName("FK__UsersBran__Branc__02FC7413");

        builder.HasOne(d => d.User).WithMany(p => p.UsersBranchOffices)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("FK__UsersBran__UserI__03F0984C");
    }
}
