﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Validation.DMO;

public partial class PersonelContext : DbContext
{
    public PersonelContext()
    {
    }

    public PersonelContext(DbContextOptions<PersonelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CEVAHIR\\SQLEXPRESS; Database=Personel; Trusted_Connection= true;TrustServerCertificate=True");



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.IdentityNo).HasMaxLength(11);
            entity.Property(e => e.LastName).HasMaxLength(15);
            entity.Property(e => e.Name).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
