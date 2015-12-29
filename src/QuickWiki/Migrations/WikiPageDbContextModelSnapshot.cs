using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using QuickWiki.Models;

namespace QuickWiki.Migrations
{
    [DbContext(typeof(WikiPageDbContext))]
    partial class WikiPageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("QuickWiki.Models.WikiPage", b =>
                {
                    b.Property<int>("WikiPageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("PageName");

                    b.HasKey("WikiPageId");
                });
        }
    }
}
