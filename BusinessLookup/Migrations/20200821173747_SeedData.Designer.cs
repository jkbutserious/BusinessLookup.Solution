﻿// <auto-generated />
using BusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessLookup.Migrations
{
    [DbContext(typeof(BusinessLookupContext))]
    [Migration("20200821173747_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessLookup.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cuisine");

                    b.Property<string>("Name");

                    b.Property<uint>("PhoneNumber");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Cuisine = "Ice Cream",
                            Name = "Tom and Mickey's",
                            PhoneNumber = 4255550005u
                        },
                        new
                        {
                            RestaurantId = 2,
                            Cuisine = "Italian",
                            Name = "Caper Greenhouse",
                            PhoneNumber = 4255550006u
                        },
                        new
                        {
                            RestaurantId = 3,
                            Cuisine = "Burgers",
                            Name = "Blue Bluejay",
                            PhoneNumber = 4255550007u
                        },
                        new
                        {
                            RestaurantId = 4,
                            Cuisine = "Bakery",
                            Name = "185F",
                            PhoneNumber = 4255550008u
                        });
                });

            modelBuilder.Entity("BusinessLookup.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<uint>("PhoneNumber");

                    b.Property<string>("Type");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Name = "The Crevasse",
                            PhoneNumber = 4255550001u,
                            Type = "Clothing"
                        },
                        new
                        {
                            ShopId = 2,
                            Name = "The Crisper Picture",
                            PhoneNumber = 4255550002u,
                            Type = "Electronics"
                        },
                        new
                        {
                            ShopId = 3,
                            Name = "Farmhouse and Highborn",
                            PhoneNumber = 4255550003u,
                            Type = "Book"
                        },
                        new
                        {
                            ShopId = 4,
                            Name = "QXNickel",
                            PhoneNumber = 4255550004u,
                            Type = "Department Store"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
