// <auto-generated />
using CarInformationTask.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarInformationTask.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20211117171932_AddedDataToModels")]
    partial class AddedDataToModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarInformationTask.Entities.Models.CarMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CarMakes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mercedes"
                        });
                });

            modelBuilder.Entity("CarInformationTask.Entities.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarMakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarMakeId");

                    b.ToTable("CarModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarMakeId = 1,
                            Name = "Q7",
                            Price = "38.000 AZN",
                            Year = 2015
                        },
                        new
                        {
                            Id = 2,
                            CarMakeId = 2,
                            Name = "X5",
                            Price = "150.000 AZN",
                            Year = 2019
                        },
                        new
                        {
                            Id = 3,
                            CarMakeId = 1,
                            Name = "A3",
                            Price = "80.000 AZN",
                            Year = 2015
                        },
                        new
                        {
                            Id = 4,
                            CarMakeId = 3,
                            Name = "C Class",
                            Price = "55.400 AZN",
                            Year = 2013
                        });
                });

            modelBuilder.Entity("CarInformationTask.Entities.Models.CarModel", b =>
                {
                    b.HasOne("CarInformationTask.Entities.Models.CarMake", "CarMake")
                        .WithMany("CarModels")
                        .HasForeignKey("CarMakeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CarMake");
                });

            modelBuilder.Entity("CarInformationTask.Entities.Models.CarMake", b =>
                {
                    b.Navigation("CarModels");
                });
#pragma warning restore 612, 618
        }
    }
}
