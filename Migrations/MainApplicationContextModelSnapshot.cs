﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppiUsers.Context;

#nullable disable

namespace WebAppiUsers.Migrations
{
    [DbContext(typeof(MainApplicationContext))]
    partial class MainApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("WebAppiUsers.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sso")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(816),
                            FirstName = "Patryk",
                            LastName = "Szwermer",
                            Sso = 222222221
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1939),
                            FirstName = "Przemyslaw",
                            LastName = "Sawicki",
                            Sso = 222222222
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1941),
                            FirstName = "Marcin",
                            LastName = "Dabrowski",
                            Sso = 222222223
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1942),
                            FirstName = "Piotr",
                            LastName = "Katny",
                            Sso = 222222224
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1943),
                            FirstName = "Marcin",
                            LastName = "Dudzic",
                            Sso = 222222225
                        },
                        new
                        {
                            Id = 6,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1946),
                            FirstName = "Maciej",
                            LastName = "Krakowiak",
                            Sso = 222222226
                        },
                        new
                        {
                            Id = 7,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1947),
                            FirstName = "Mateusz",
                            LastName = "Cebula",
                            Sso = 222222227
                        },
                        new
                        {
                            Id = 8,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1947),
                            FirstName = "Jakub",
                            LastName = "Nowikowski",
                            Sso = 222222228
                        },
                        new
                        {
                            Id = 9,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1948),
                            FirstName = "Jan",
                            LastName = "Choma",
                            Sso = 222222229
                        },
                        new
                        {
                            Id = 10,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1949),
                            FirstName = "Marcin",
                            LastName = "Przypek",
                            Sso = 322222221
                        },
                        new
                        {
                            Id = 11,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1950),
                            FirstName = "Michal",
                            LastName = "Sosnowski",
                            Sso = 422222221
                        },
                        new
                        {
                            Id = 12,
                            CreatedOn = new DateTime(2022, 4, 13, 8, 52, 1, 400, DateTimeKind.Utc).AddTicks(1951),
                            FirstName = "Maciej",
                            LastName = "Tyszka",
                            Sso = 522222221
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
