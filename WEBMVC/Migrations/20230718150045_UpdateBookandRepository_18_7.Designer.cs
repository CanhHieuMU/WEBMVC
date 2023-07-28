﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBMVC.Data;

#nullable disable

namespace WEBMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230718150045_UpdateBookandRepository_18_7")]
    partial class UpdateBookandRepository_18_7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCategoryBook", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryBooksCategoryBookId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "CategoryBooksCategoryBookId");

                    b.HasIndex("CategoryBooksCategoryBookId");

                    b.ToTable("BookCategoryBook");
                });

            modelBuilder.Entity("BookRepository", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("RepositoriesRepositoryID")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "RepositoriesRepositoryID");

                    b.HasIndex("RepositoriesRepositoryID");

                    b.ToTable("BookRepository");
                });

            modelBuilder.Entity("WEBMVC.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Passwords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Usernames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryRoleId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WEBMVC.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<DateTime>("DatePublic")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WEBMVC.Models.CategoryBook", b =>
                {
                    b.Property<int>("CategoryBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryBookId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryBookId");

                    b.ToTable("CategoryBooks");
                });

            modelBuilder.Entity("WEBMVC.Models.CategoryRole", b =>
                {
                    b.Property<int>("CategoryRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryRoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryRoleId");

                    b.ToTable("CategoryRoles");
                });

            modelBuilder.Entity("WEBMVC.Models.Repository", b =>
                {
                    b.Property<int>("RepositoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RepositoryID"));

                    b.Property<string>("RepositoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RepositoryID");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("WEBMVC.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookCategoryBook", b =>
                {
                    b.HasOne("WEBMVC.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBMVC.Models.CategoryBook", null)
                        .WithMany()
                        .HasForeignKey("CategoryBooksCategoryBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookRepository", b =>
                {
                    b.HasOne("WEBMVC.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBMVC.Models.Repository", null)
                        .WithMany()
                        .HasForeignKey("RepositoriesRepositoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEBMVC.Models.Account", b =>
                {
                    b.HasOne("WEBMVC.Models.CategoryRole", "CategoryRoleID")
                        .WithMany()
                        .HasForeignKey("CategoryRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBMVC.Models.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("WEBMVC.Models.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryRoleID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WEBMVC.Models.Repository", b =>
                {
                    b.HasOne("WEBMVC.Models.User", "User")
                        .WithOne("Repository")
                        .HasForeignKey("WEBMVC.Models.Repository", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WEBMVC.Models.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("Repository")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
