using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TodoApp.Data;

namespace TodoApp.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20170513150714_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("TodoApp.Models.Todo", b =>
                {
                    b.Property<long>("TodoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.Property<long>("UserId");

                    b.HasKey("TodoId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("TodoApp.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
        }
    }
}
