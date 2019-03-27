﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourEZ.Models;

namespace TourEZ.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190327165946_Migration6")]
    partial class Migration6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TourEZ.Models.Event", b =>
                {
                    b.Property<int>("eventId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created_at");

                    b.Property<DateTime>("endDate");

                    b.Property<DateTime>("endTime");

                    b.Property<string>("eventName");

                    b.Property<string>("location");

                    b.Property<DateTime>("startDate");

                    b.Property<DateTime>("startTime");

                    b.HasKey("eventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TourEZ.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
