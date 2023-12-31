﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Context.Configurations;

public class PurcharseDetailConfiguration : IEntityTypeConfiguration<PurcharseDetail>
{
    public void Configure(EntityTypeBuilder<PurcharseDetail> builder)
    {
        builder.HasKey(e => e.PurcharseDetailId).HasName("PK__Purchars__7353248BE0B1CD5B");

        builder.Property(e => e.Price).HasColumnType("decimal(18, 2)");

        builder.HasOne(d => d.Product).WithMany(p => p.PurcharseDetails)
            .HasForeignKey(d => d.ProductId)
            .HasConstraintName("FK__Purcharse__Produ__1EA48E88");

        builder.HasOne(d => d.Purcharse).WithMany(p => p.PurcharseDetails)
            .HasForeignKey(d => d.PurcharseId)
            .HasConstraintName("FK__Purcharse__Purch__1F98B2C1");
    }
}
