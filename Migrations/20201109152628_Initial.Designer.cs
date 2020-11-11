﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ONLNSTR.Data;

namespace ONLNSTR.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20201109152628_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeautySPA.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("description");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BeautySPA.Data.Models.Watch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("categoryid");

                    b.Property<string>("description");

                    b.Property<bool>("favourites");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<string>("parameter");

                    b.Property<int>("price");

                    b.HasKey("id");

                    b.HasIndex("categoryid");

                    b.ToTable("Watch");
                });

            modelBuilder.Entity("BeautySPA.Data.Models.Watch", b =>
                {
                    b.HasOne("BeautySPA.Data.Models.Category", "Category")
                        .WithMany("watches")
                        .HasForeignKey("categoryid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
