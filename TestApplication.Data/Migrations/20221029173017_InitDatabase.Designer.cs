﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestApplication.Data.Models;

#nullable disable

namespace TestApplication.Data.Migrations
{
    [DbContext(typeof(FormAppContext))]
    [Migration("20221029173017_InitDatabase")]
    partial class InitDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestApplication.Data.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("SectorCode")
                        .HasColumnType("integer")
                        .HasColumnName("sector_id");

                    b.Property<string>("SectorName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sector_name");

                    b.Property<int>("SectorParentCode")
                        .HasColumnType("integer")
                        .HasColumnName("sector_parent_id");

                    b.HasKey("Id")
                        .HasName("PK_sector_id");

                    b.HasIndex(new[] { "SectorCode" }, "sector_sector_id_key")
                        .IsUnique();

                    b.ToTable("sector", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SectorCode = 1,
                            SectorName = "Manufacturing",
                            SectorParentCode = 0
                        },
                        new
                        {
                            Id = 2,
                            SectorCode = 19,
                            SectorName = "Construction materials",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 3,
                            SectorCode = 18,
                            SectorName = "Electronics and Optics",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 4,
                            SectorCode = 6,
                            SectorName = "Food and Beverage",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 5,
                            SectorCode = 342,
                            SectorName = "Bakery & confectionery products",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 6,
                            SectorCode = 43,
                            SectorName = "Beverages",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 7,
                            SectorCode = 42,
                            SectorName = "Fish & fish products",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 8,
                            SectorCode = 40,
                            SectorName = "Meat & meat products",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 9,
                            SectorCode = 39,
                            SectorName = "Milk  & dairy products",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 10,
                            SectorCode = 378,
                            SectorName = "Sweets & snack food",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 11,
                            SectorCode = 437,
                            SectorName = "Other",
                            SectorParentCode = 6
                        },
                        new
                        {
                            Id = 12,
                            SectorCode = 13,
                            SectorName = "Furniture",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 13,
                            SectorCode = 389,
                            SectorName = "Bathroom/sauna",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 14,
                            SectorCode = 385,
                            SectorName = "Bedroom",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 15,
                            SectorCode = 390,
                            SectorName = "Children’s room",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 16,
                            SectorCode = 98,
                            SectorName = "Kitchen ",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 17,
                            SectorCode = 101,
                            SectorName = "Living room",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 18,
                            SectorCode = 392,
                            SectorName = "Office",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 19,
                            SectorCode = 341,
                            SectorName = "Outdoor",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 20,
                            SectorCode = 99,
                            SectorName = "Project furniture",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 21,
                            SectorCode = 394,
                            SectorName = "Other (Furniture)",
                            SectorParentCode = 13
                        },
                        new
                        {
                            Id = 22,
                            SectorCode = 12,
                            SectorName = "Machinery ",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 23,
                            SectorCode = 94,
                            SectorName = "Machinery components",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 24,
                            SectorCode = 91,
                            SectorName = "Machinery equipment/tools",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 25,
                            SectorCode = 224,
                            SectorName = "Manufacture of machinery",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 26,
                            SectorCode = 97,
                            SectorName = "Maritime",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 27,
                            SectorCode = 271,
                            SectorName = "Aluminium and steel workboats",
                            SectorParentCode = 97
                        },
                        new
                        {
                            Id = 28,
                            SectorCode = 269,
                            SectorName = "Boat/Yacht building",
                            SectorParentCode = 97
                        },
                        new
                        {
                            Id = 29,
                            SectorCode = 230,
                            SectorName = "Ship repair and conversion",
                            SectorParentCode = 97
                        },
                        new
                        {
                            Id = 30,
                            SectorCode = 93,
                            SectorName = "Metal structures",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 31,
                            SectorCode = 227,
                            SectorName = "Repair and maintenance service",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 32,
                            SectorCode = 508,
                            SectorName = "Other",
                            SectorParentCode = 12
                        },
                        new
                        {
                            Id = 33,
                            SectorCode = 11,
                            SectorName = "Metalworking",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 34,
                            SectorCode = 67,
                            SectorName = "Construction of metal structures",
                            SectorParentCode = 11
                        },
                        new
                        {
                            Id = 35,
                            SectorCode = 263,
                            SectorName = "Houses and buildings",
                            SectorParentCode = 11
                        },
                        new
                        {
                            Id = 36,
                            SectorCode = 267,
                            SectorName = "Metal products",
                            SectorParentCode = 11
                        },
                        new
                        {
                            Id = 37,
                            SectorCode = 542,
                            SectorName = "Metal works",
                            SectorParentCode = 11
                        },
                        new
                        {
                            Id = 38,
                            SectorCode = 75,
                            SectorName = "CNC-machining",
                            SectorParentCode = 542
                        },
                        new
                        {
                            Id = 39,
                            SectorCode = 62,
                            SectorName = "Forgings, Fasteners",
                            SectorParentCode = 542
                        },
                        new
                        {
                            Id = 40,
                            SectorCode = 69,
                            SectorName = "Gas, Plasma, Laser cutting",
                            SectorParentCode = 542
                        },
                        new
                        {
                            Id = 41,
                            SectorCode = 66,
                            SectorName = "MIG, TIG, Aluminum welding",
                            SectorParentCode = 542
                        },
                        new
                        {
                            Id = 42,
                            SectorCode = 9,
                            SectorName = "Plastic and Rubber",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 43,
                            SectorCode = 54,
                            SectorName = "Packaging",
                            SectorParentCode = 9
                        },
                        new
                        {
                            Id = 44,
                            SectorCode = 556,
                            SectorName = "Plastic goods",
                            SectorParentCode = 9
                        },
                        new
                        {
                            Id = 45,
                            SectorCode = 559,
                            SectorName = "Plastic processing technology",
                            SectorParentCode = 9
                        },
                        new
                        {
                            Id = 46,
                            SectorCode = 55,
                            SectorName = "Blowing",
                            SectorParentCode = 559
                        },
                        new
                        {
                            Id = 47,
                            SectorCode = 57,
                            SectorName = "Moulding",
                            SectorParentCode = 559
                        },
                        new
                        {
                            Id = 48,
                            SectorCode = 53,
                            SectorName = "Plastics welding and processing",
                            SectorParentCode = 559
                        },
                        new
                        {
                            Id = 49,
                            SectorCode = 560,
                            SectorName = "Plastic profiles",
                            SectorParentCode = 9
                        },
                        new
                        {
                            Id = 50,
                            SectorCode = 5,
                            SectorName = "Printing ",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 51,
                            SectorCode = 148,
                            SectorName = "Advertising ",
                            SectorParentCode = 5
                        },
                        new
                        {
                            Id = 52,
                            SectorCode = 150,
                            SectorName = "Book/Periodicals printing",
                            SectorParentCode = 5
                        },
                        new
                        {
                            Id = 53,
                            SectorCode = 145,
                            SectorName = "Labelling and packaging printing",
                            SectorParentCode = 5
                        },
                        new
                        {
                            Id = 54,
                            SectorCode = 7,
                            SectorName = "Textile and Clothing",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 55,
                            SectorCode = 44,
                            SectorName = "Clothing",
                            SectorParentCode = 7
                        },
                        new
                        {
                            Id = 56,
                            SectorCode = 45,
                            SectorName = "Textile",
                            SectorParentCode = 7
                        },
                        new
                        {
                            Id = 57,
                            SectorCode = 8,
                            SectorName = "Wood",
                            SectorParentCode = 1
                        },
                        new
                        {
                            Id = 58,
                            SectorCode = 51,
                            SectorName = "Wooden building materials",
                            SectorParentCode = 8
                        },
                        new
                        {
                            Id = 59,
                            SectorCode = 47,
                            SectorName = "Wooden houses",
                            SectorParentCode = 8
                        },
                        new
                        {
                            Id = 60,
                            SectorCode = 337,
                            SectorName = "Other",
                            SectorParentCode = 8
                        },
                        new
                        {
                            Id = 61,
                            SectorCode = 2,
                            SectorName = "Service",
                            SectorParentCode = 0
                        },
                        new
                        {
                            Id = 62,
                            SectorCode = 25,
                            SectorName = "Business services",
                            SectorParentCode = 2
                        },
                        new
                        {
                            Id = 63,
                            SectorCode = 35,
                            SectorName = "Engineering",
                            SectorParentCode = 2
                        },
                        new
                        {
                            Id = 64,
                            SectorCode = 28,
                            SectorName = "Information Technology and Telecommunications",
                            SectorParentCode = 2
                        },
                        new
                        {
                            Id = 65,
                            SectorCode = 581,
                            SectorName = "Data processing, Web portals, E-marketing",
                            SectorParentCode = 28
                        },
                        new
                        {
                            Id = 66,
                            SectorCode = 576,
                            SectorName = "Programming, Consultancy",
                            SectorParentCode = 28
                        },
                        new
                        {
                            Id = 67,
                            SectorCode = 121,
                            SectorName = "Software, Hardware",
                            SectorParentCode = 28
                        },
                        new
                        {
                            Id = 68,
                            SectorCode = 122,
                            SectorName = "Telecommunications",
                            SectorParentCode = 28
                        },
                        new
                        {
                            Id = 69,
                            SectorCode = 22,
                            SectorName = "Tourism",
                            SectorParentCode = 2
                        },
                        new
                        {
                            Id = 70,
                            SectorCode = 141,
                            SectorName = "Translation services",
                            SectorParentCode = 2
                        },
                        new
                        {
                            Id = 71,
                            SectorCode = 21,
                            SectorName = "Transport and Logistics",
                            SectorParentCode = 2
                        },
                        new
                        {
                            Id = 72,
                            SectorCode = 111,
                            SectorName = "Air",
                            SectorParentCode = 21
                        },
                        new
                        {
                            Id = 73,
                            SectorCode = 114,
                            SectorName = "Rail",
                            SectorParentCode = 21
                        },
                        new
                        {
                            Id = 74,
                            SectorCode = 112,
                            SectorName = "Road",
                            SectorParentCode = 21
                        },
                        new
                        {
                            Id = 75,
                            SectorCode = 113,
                            SectorName = "Water",
                            SectorParentCode = 21
                        },
                        new
                        {
                            Id = 76,
                            SectorCode = 3,
                            SectorName = "Other",
                            SectorParentCode = 0
                        },
                        new
                        {
                            Id = 77,
                            SectorCode = 37,
                            SectorName = "Creative industries",
                            SectorParentCode = 3
                        },
                        new
                        {
                            Id = 78,
                            SectorCode = 29,
                            SectorName = "Energy technology",
                            SectorParentCode = 3
                        },
                        new
                        {
                            Id = 79,
                            SectorCode = 33,
                            SectorName = "Environment",
                            SectorParentCode = 3
                        });
                });

            modelBuilder.Entity("TestApplication.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AgreedToTerms")
                        .HasColumnType("boolean")
                        .HasColumnName("agreed_to_terms");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK_user_id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("TestApplication.Data.Models.UserSector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("SectorId")
                        .HasColumnType("integer")
                        .HasColumnName("sector_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PK_user_sector_key");

                    b.HasIndex("SectorId");

                    b.HasIndex("UserId");

                    b.ToTable("user_sector", (string)null);
                });

            modelBuilder.Entity("TestApplication.Data.Models.UserSector", b =>
                {
                    b.HasOne("TestApplication.Data.Models.Sector", "Sector")
                        .WithMany("UserSector")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("user_sector_sector_id_fkey");

                    b.HasOne("TestApplication.Data.Models.User", "User")
                        .WithMany("UserSector")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("user_sector_user_id_fkey");

                    b.Navigation("Sector");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestApplication.Data.Models.Sector", b =>
                {
                    b.Navigation("UserSector");
                });

            modelBuilder.Entity("TestApplication.Data.Models.User", b =>
                {
                    b.Navigation("UserSector");
                });
#pragma warning restore 612, 618
        }
    }
}
