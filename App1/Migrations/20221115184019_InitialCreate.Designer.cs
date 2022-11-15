﻿// <auto-generated />
using System;
using App1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221115184019_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("App1.Models.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Body")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Craft")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Dexterity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Emphaty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Homeland")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Luck")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Reflexes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Social_Standing")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Will")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 112,
                            Body = 0,
                            Craft = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Dexterity = 0,
                            Emphaty = 0,
                            Homeland = "",
                            Intelligence = 0,
                            Luck = 0,
                            Name = "Geralt",
                            Race = "Witcher",
                            Reflexes = 0,
                            Sex = "Male",
                            SocialStanding = "",
                            Speed = 0,
                            Will = 0
                        },
                        new
                        {
                            ID = 2,
                            Age = 85,
                            Body = 0,
                            Craft = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Dexterity = 0,
                            Emphaty = 0,
                            Homeland = "",
                            Intelligence = 0,
                            Luck = 0,
                            Name = "Yennefer",
                            Race = "Human",
                            Reflexes = 0,
                            Sex = "Female",
                            SocialStanding = "",
                            Speed = 0,
                            Will = 0
                        },
                        new
                        {
                            ID = 3,
                            Age = 62,
                            Body = 0,
                            Craft = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Dexterity = 0,
                            Emphaty = 0,
                            Homeland = "",
                            Intelligence = 0,
                            Luck = 0,
                            Name = "Zoltan Chivay",
                            Race = "Dwarf",
                            Reflexes = 0,
                            Sex = "Male",
                            SocialStanding = "",
                            Speed = 0,
                            Will = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
