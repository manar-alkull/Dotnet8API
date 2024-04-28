﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dotnet8API.Models;

public partial class ContactMgmtAPIContext : DbContext
{
    public ContactMgmtAPIContext(DbContextOptions<ContactMgmtAPIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC2778441CAB");

            entity.ToTable("Contact");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.EmailAddress).HasColumnName("EmailADdress");
            entity.Property(e => e.FierstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}