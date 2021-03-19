﻿// <auto-generated />
using CourseWork.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseWork.Data.Migrations
{
    [DbContext(typeof(MssqlDbContext))]
    [Migration("20210315104535_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseWork.Shared.Models.BookModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("book_id");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasColumnName("book_description");

                    b.Property<string>("ISBN")
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)")
                        .HasColumnName("book_isbn");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("book_name");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int")
                        .HasColumnName("book_publish_year");

                    b.HasKey("Id")
                        .HasName("book_pkey");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CourseWork.Shared.Models.KeyWordModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("key_word_id");

                    b.Property<string>("BookModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Word")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("key_word");

                    b.HasKey("Id")
                        .HasName("key_word_pkey");

                    b.HasIndex("BookModelId");

                    b.ToTable("KeyWordModel");
                });

            modelBuilder.Entity("CourseWork.Shared.Models.AuthorModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("user_first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("user_last_name");

                    b.HasKey("Id")
                        .HasName("user_pkey");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CourseWork.Shared.Models.BookModel", b =>
                {
                    b.HasOne("CourseWork.Shared.Models.AuthorModel", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("CourseWork.Shared.Models.KeyWordModel", b =>
                {
                    b.HasOne("CourseWork.Shared.Models.BookModel", null)
                        .WithMany("KeyWordsString")
                        .HasForeignKey("BookModelId");
                });

            modelBuilder.Entity("CourseWork.Shared.Models.BookModel", b =>
                {
                    b.Navigation("KeyWordsString");
                });
#pragma warning restore 612, 618
        }
    }
}
