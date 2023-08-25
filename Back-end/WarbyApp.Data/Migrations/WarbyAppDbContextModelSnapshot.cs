﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarbyApp.Data;

#nullable disable

namespace WarbyApp.Data.Migrations
{
    [DbContext(typeof(WarbyAppDbContext))]
    partial class WarbyAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WarbyApp.Core.Entities.BridgeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BridgeCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.ColorCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColorCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.ColorImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ColorImages");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.Eyeglasses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AllCategory")
                        .HasColumnType("bit");

                    b.Property<bool>("AutumnaltonesCategory")
                        .HasColumnType("bit");

                    b.Property<bool>("BestsellersCategory")
                        .HasColumnType("bit");

                    b.Property<bool>("BoldshapesCategory")
                        .HasColumnType("bit");

                    b.Property<bool>("ClassicmetalsCategory")
                        .HasColumnType("bit");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("money");

                    b.Property<string>("Description1")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Description2")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("MenCategory")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("NewarrivalsCategory")
                        .HasColumnType("bit");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("money");

                    b.Property<bool>("WomenCategory")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Eyeglasses");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesBridgeCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("BridgeCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "BridgeCategoryId");

                    b.HasIndex("BridgeCategoryId");

                    b.ToTable("EyeglassesBridgeCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesColorCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("ColorCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "ColorCategoryId");

                    b.HasIndex("ColorCategoryId");

                    b.ToTable("EyeglassesColorCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesFeaturesCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("FeaturesCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "FeaturesCategoryId");

                    b.HasIndex("FeaturesCategoryId");

                    b.ToTable("EyeglassesFeaturesCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorImageId")
                        .HasColumnType("int");

                    b.Property<int?>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorImageId");

                    b.HasIndex("EyeglassesId");

                    b.ToTable("EyeglassesImages");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesMaterialCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "MaterialCategoryId");

                    b.HasIndex("MaterialCategoryId");

                    b.ToTable("EyeglassesMaterialCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesPrescriptionCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "PrescriptionCategoryId");

                    b.HasIndex("PrescriptionCategoryId");

                    b.ToTable("EyeglassesPrescriptionCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesPriceCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("PriceCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "PriceCategoryId");

                    b.HasIndex("PriceCategoryId");

                    b.ToTable("EyeglassesPriceCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesShapeCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("ShapeCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "ShapeCategoryId");

                    b.HasIndex("ShapeCategoryId");

                    b.ToTable("EyeglassesShapeCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesWidthCategory", b =>
                {
                    b.Property<int>("EyeglassesId")
                        .HasColumnType("int");

                    b.Property<int>("WidthCategoryId")
                        .HasColumnType("int");

                    b.HasKey("EyeglassesId", "WidthCategoryId");

                    b.HasIndex("WidthCategoryId");

                    b.ToTable("EyeglassesWidthCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.FeaturesCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FeaturesCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.MaterialCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.PrescriptionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PrescriptionCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.PriceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PriceCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.ShapeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShapeCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.WidthCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WidthCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesBridgeCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.BridgeCategory", "BridgeCategory")
                        .WithMany("EyeglassesBridgeCategories")
                        .HasForeignKey("BridgeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany()
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BridgeCategory");

                    b.Navigation("Eyeglasses");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesColorCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.ColorCategory", "ColorCategory")
                        .WithMany("EyeglassesColorCategories")
                        .HasForeignKey("ColorCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesColorCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColorCategory");

                    b.Navigation("Eyeglasses");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesFeaturesCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesFeaturesCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.FeaturesCategory", "FeaturesCategory")
                        .WithMany("EyeglassesFeaturesCategories")
                        .HasForeignKey("FeaturesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyeglasses");

                    b.Navigation("FeaturesCategory");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesImage", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.ColorImage", "ColorImage")
                        .WithMany("EyeglassesImages")
                        .HasForeignKey("ColorImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", null)
                        .WithMany("EyeglassesImages")
                        .HasForeignKey("EyeglassesId");

                    b.Navigation("ColorImage");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesMaterialCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesMaterialCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.MaterialCategory", "MaterialCategory")
                        .WithMany("EyeglassesMaterialCategories")
                        .HasForeignKey("MaterialCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyeglasses");

                    b.Navigation("MaterialCategory");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesPrescriptionCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesPrescriptionCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.PrescriptionCategory", "PrescriptionCategory")
                        .WithMany("EyeglassesPrescriptionCategories")
                        .HasForeignKey("PrescriptionCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyeglasses");

                    b.Navigation("PrescriptionCategory");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesPriceCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesPriceCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.PriceCategory", "PriceCategory")
                        .WithMany("EyeglassesPriceCategories")
                        .HasForeignKey("PriceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyeglasses");

                    b.Navigation("PriceCategory");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesShapeCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesShapeCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.ShapeCategory", "ShapeCategory")
                        .WithMany("EyeglassesShapeCategories")
                        .HasForeignKey("ShapeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyeglasses");

                    b.Navigation("ShapeCategory");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.EyeglassesWidthCategory", b =>
                {
                    b.HasOne("WarbyApp.Core.Entities.Eyeglasses", "Eyeglasses")
                        .WithMany("EyeglassesWidthCategories")
                        .HasForeignKey("EyeglassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarbyApp.Core.Entities.WidthCategory", "WidthCategory")
                        .WithMany("EyeglassesWidthCategories")
                        .HasForeignKey("WidthCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eyeglasses");

                    b.Navigation("WidthCategory");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.BridgeCategory", b =>
                {
                    b.Navigation("EyeglassesBridgeCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.ColorCategory", b =>
                {
                    b.Navigation("EyeglassesColorCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.ColorImage", b =>
                {
                    b.Navigation("EyeglassesImages");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.Eyeglasses", b =>
                {
                    b.Navigation("EyeglassesColorCategories");

                    b.Navigation("EyeglassesFeaturesCategories");

                    b.Navigation("EyeglassesImages");

                    b.Navigation("EyeglassesMaterialCategories");

                    b.Navigation("EyeglassesPrescriptionCategories");

                    b.Navigation("EyeglassesPriceCategories");

                    b.Navigation("EyeglassesShapeCategories");

                    b.Navigation("EyeglassesWidthCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.FeaturesCategory", b =>
                {
                    b.Navigation("EyeglassesFeaturesCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.MaterialCategory", b =>
                {
                    b.Navigation("EyeglassesMaterialCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.PrescriptionCategory", b =>
                {
                    b.Navigation("EyeglassesPrescriptionCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.PriceCategory", b =>
                {
                    b.Navigation("EyeglassesPriceCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.ShapeCategory", b =>
                {
                    b.Navigation("EyeglassesShapeCategories");
                });

            modelBuilder.Entity("WarbyApp.Core.Entities.WidthCategory", b =>
                {
                    b.Navigation("EyeglassesWidthCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
