﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppHub.Models;

namespace WebAppHub.Migrations
{
    [DbContext(typeof(DbContextTodo))]
    partial class DbContextTodoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("WebAppHub.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(150);

                    b.Property<bool>("Done")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("todos");
                });
#pragma warning restore 612, 618
        }
    }
}
