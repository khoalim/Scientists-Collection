﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apimastery.Data;

namespace apimastery.Migrations
{
    [DbContext(typeof(ScienceContext))]
    partial class ScienceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("apimastery.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Fields");

                    b.HasData(
                        new { Id = 1, Description = "Study of Plants", Image = "/Images/botany.jpeg", Name = "Botany", SubjectId = 1 },
                        new { Id = 2, Description = "Study of Animals", Image = "/Images/zoology.jpeg", Name = "Zoology", SubjectId = 1 },
                        new { Id = 3, Description = "Refers to Theories of physics that predate modern, more complete, or more widely applicable theories", Image = "/Images/classicalphys.jpeg", Name = "Classical", SubjectId = 2 },
                        new { Id = 4, Description = "Study of atomic nuclei and their constituents and interactions", Image = "/Images/nuclearphys.jpeg", Name = "Nuclear", SubjectId = 2 },
                        new { Id = 5, Description = "Study of Structures, Properties, and Reactions of Organic Compounds Which Contains Carbon Bonds", Image = "/Images/organic.jpeg", Name = "Organic", SubjectId = 3 },
                        new { Id = 6, Description = "Study of Macroscopic, Atomic, Subatomic, and Particulate Phenomena in Chemical Systems", Image = "/Images/physicalchem.jpeg", Name = "Physical", SubjectId = 3 }
                    );
                });

            modelBuilder.Entity("apimastery.Models.Scientist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Birthplace");

                    b.Property<string>("Contribution");

                    b.Property<int>("FieldId");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("Scientists");

                    b.HasData(
                        new { Id = 1, Age = 62, Birthplace = "Austria", Contribution = "Creating the science of Genetics", FieldId = 1, Image = "/Images/mendel.jpg", Name = "Gregor Mendel" },
                        new { Id = 2, Age = 73, Birthplace = "England", Contribution = "On the Origin of Species", FieldId = 2, Image = "/Images/darwin.jpg", Name = "Charles Darwin" },
                        new { Id = 3, Age = 75, Birthplace = "England", Contribution = "Faraday's Law of Induction", FieldId = 3, Image = "/Images/faraday.jpg", Name = "Michael Faraday" },
                        new { Id = 4, Age = 76, Birthplace = "Germany", Contribution = "General relativity", FieldId = 4, Image = "/Images/einstein.jpg", Name = "Albert Einstein" },
                        new { Id = 5, Age = 62, Birthplace = "USA", Contribution = "Molecular Structure determination", FieldId = 5, Image = "/Images/woodward.jpg", Name = "Robert Burns Woodward" },
                        new { Id = 6, Age = 86, Birthplace = "Switzerland", Contribution = "NMR Spectroscopy", FieldId = 6, Image = "/Images/ernst.jpg", Name = "Richard Robert Ernst" }
                    );
                });

            modelBuilder.Entity("apimastery.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new { Id = 1, Description = "Study of Life", Image = "/Images/biology.jpeg", Name = "Biology" },
                        new { Id = 2, Description = "Study of Nature and Properties of Matter and Energy", Image = "/Images/physics.jpeg", Name = "Physics" },
                        new { Id = 3, Description = "Study of Elements and Compounds", Image = "/Images/chemistry.jpeg", Name = "Chemistry" }
                    );
                });

            modelBuilder.Entity("apimastery.Models.Field", b =>
                {
                    b.HasOne("apimastery.Models.Subject", "Subject")
                        .WithMany("Fields")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("apimastery.Models.Scientist", b =>
                {
                    b.HasOne("apimastery.Models.Field", "Field")
                        .WithMany("Scientists")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
