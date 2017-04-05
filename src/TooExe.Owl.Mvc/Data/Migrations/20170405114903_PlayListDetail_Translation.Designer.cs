using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TooExe.Owl.Mvc.Data;

namespace TooExe.Owl.Mvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170405114903_PlayListDetail_Translation")]
    partial class PlayListDetail_Translation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<int>("IdOwlUser");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("IdOwlUser");

                    b.ToTable("Articles","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.ArticleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdArticle");

                    b.Property<int>("IdTranslation");

                    b.HasKey("Id");

                    b.HasIndex("IdArticle");

                    b.ToTable("ArticleDetails","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.EnglishWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<string>("Word");

                    b.HasKey("Id");

                    b.ToTable("EnglishWords","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.KnownWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdProfile");

                    b.Property<int>("IdTranslation");

                    b.HasKey("Id");

                    b.ToTable("KnownWords","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.OwlUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExternalIdUser");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OwlUsers","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.PlayList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<int>("IdDocument");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("IdDocument");

                    b.ToTable("PlayLists","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.PlayListDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdPlayList");

                    b.Property<int>("IdTranslation");

                    b.HasKey("Id");

                    b.HasIndex("IdPlayList");

                    b.HasIndex("IdTranslation");

                    b.ToTable("PlayListDetails","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.PolishWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<int>("IdEnglishWord");

                    b.Property<string>("Translate");

                    b.HasKey("Id");

                    b.ToTable("PolishWords","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdEnglishWord");

                    b.Property<int>("IdPolishWord");

                    b.HasKey("Id");

                    b.ToTable("Translations","Owl");
                });

            modelBuilder.Entity("TooExe.Owl.Mvc.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TooExe.Owl.Mvc.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TooExe.Owl.Mvc.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TooExe.Owl.Mvc.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.Article", b =>
                {
                    b.HasOne("TooExe.Owl.Library.Model.OwlUser", "OwlUser")
                        .WithMany("Articles")
                        .HasForeignKey("IdOwlUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.ArticleDetail", b =>
                {
                    b.HasOne("TooExe.Owl.Library.Model.Article", "Article")
                        .WithMany("ArticleDetails")
                        .HasForeignKey("IdArticle")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.PlayList", b =>
                {
                    b.HasOne("TooExe.Owl.Library.Model.Article", "Article")
                        .WithMany("PlayLists")
                        .HasForeignKey("IdDocument")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TooExe.Owl.Library.Model.PlayListDetail", b =>
                {
                    b.HasOne("TooExe.Owl.Library.Model.PlayList", "PlayList")
                        .WithMany("PlayListDetails")
                        .HasForeignKey("IdPlayList")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TooExe.Owl.Library.Model.Translation", "Translation")
                        .WithMany("PlayListDetails")
                        .HasForeignKey("IdTranslation")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
