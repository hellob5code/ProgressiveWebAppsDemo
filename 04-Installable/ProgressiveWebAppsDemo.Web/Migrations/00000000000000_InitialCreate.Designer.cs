﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProgressiveWebAppsDemo.Web.Data;
using System;

namespace ProgressiveWebAppsDemo.Web.Migrations
{
    [DbContext(typeof(ExpensesContext))]
    [Migration("20171210095107_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProgressiveWebAppsDemo.Web.Data.Category", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProgressiveWebAppsDemo.Web.Data.Movement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<short>("CategoryId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<byte[]>("Picture");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("ProgressiveWebAppsDemo.Web.Data.Movement", b =>
                {
                    b.HasOne("ProgressiveWebAppsDemo.Web.Data.Category", "Category")
                        .WithMany("Movements")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}