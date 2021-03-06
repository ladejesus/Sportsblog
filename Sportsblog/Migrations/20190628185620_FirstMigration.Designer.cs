﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sportsblog;

namespace Sportsblog.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190628185620_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sportsblog.Models.Posts", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date");

                    b.Property<string>("PostContent");

                    b.Property<int>("SportId");

                    b.Property<int>("TagId");

                    b.Property<string>("Title");

                    b.HasKey("PostId");

                    b.HasIndex("SportId");

                    b.HasIndex("TagId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { PostId = 1, Date = "", PostContent = "The woman will have there hands full with France!", SportId = 1, TagId = 3, Title = "USA Women's Team" },
                        new { PostId = 2, Date = "", PostContent = "USA took care of France with penalty kicks!", SportId = 1, TagId = 1, Title = "France Goes Down" },
                        new { PostId = 4, Date = "", PostContent = "The Cavs draft class seems to be pretty good", SportId = 2, TagId = 2, Title = "Cavs" },
                        new { PostId = 3, Date = "", PostContent = "Kevin Durant just turned down 31 mil!", SportId = 2, TagId = 2, Title = "Durant" }
                    );
                });

            modelBuilder.Entity("Sportsblog.Models.Sports", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SportName");

                    b.HasKey("SportId");

                    b.ToTable("Sports");

                    b.HasData(
                        new { SportId = 1, SportName = "Soccer" },
                        new { SportId = 2, SportName = "Basketball" }
                    );
                });

            modelBuilder.Entity("Sportsblog.Models.Tags", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { TagId = 1, TagName = "Spoiler" },
                        new { TagId = 2, TagName = "Hot Take" },
                        new { TagId = 3, TagName = "World Cup" }
                    );
                });

            modelBuilder.Entity("Sportsblog.Models.Posts", b =>
                {
                    b.HasOne("Sportsblog.Models.Sports", "Sports")
                        .WithMany("Posts")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sportsblog.Models.Tags", "Tags")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
