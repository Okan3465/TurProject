﻿// <auto-generated />
using System;
using DataAccessLayer.Concrate.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(TurContext))]
    partial class TurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("EntityLayer.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogContent")
                        .HasColumnType("TEXT");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EntityLayer.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ComentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommenUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("ContactID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentID");

                    b.HasIndex("ContactID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Finish")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Route1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Route2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Route3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("date")
                        .HasColumnType("TEXT");

                    b.HasKey("RouteId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("EntityLayer.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("RouteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.Property<string>("To")
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.HasIndex("RouteId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("EntityLayer.Comment", b =>
                {
                    b.HasOne("EntityLayer.Contact", "Contact")
                        .WithMany("Comments")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("EntityLayer.Ticket", b =>
                {
                    b.HasOne("EntityLayer.Route", "Route")
                        .WithMany("Tickets")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("EntityLayer.Contact", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("EntityLayer.Route", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
