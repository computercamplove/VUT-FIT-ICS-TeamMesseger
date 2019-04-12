﻿// <auto-generated />
using System;
using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICS.Project.BL.Migrations
{
    [DbContext(typeof(MessengerDbContext))]
    [Migration("20190410183428_Add userInTeam entity")]
    partial class AdduserInTeamentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ICS.Project.DAL.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AutorID");

                    b.Property<string>("MessageText");

                    b.Property<Guid?>("PostEntityID");

                    b.Property<DateTime>("PublishDate");

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.HasIndex("PostEntityID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.PostEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AutorID");

                    b.Property<string>("MessageText");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.TeamEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastActivity");

                    b.Property<string>("MessageText");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserInTeamEntity", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("TeamID");

                    b.Property<Guid?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("TeamID");

                    b.HasIndex("UserID");

                    b.ToTable("UserInTeam");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.CommentEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorID");

                    b.HasOne("ICS.Project.DAL.Entities.PostEntity")
                        .WithMany("Comments")
                        .HasForeignKey("PostEntityID");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.PostEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorID");
                });

            modelBuilder.Entity("ICS.Project.DAL.Entities.UserInTeamEntity", b =>
                {
                    b.HasOne("ICS.Project.DAL.Entities.TeamEntity", "Team")
                        .WithMany("UsersInTeams")
                        .HasForeignKey("TeamID");

                    b.HasOne("ICS.Project.DAL.Entities.UserEntity", "User")
                        .WithMany("UsersInTeams")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
