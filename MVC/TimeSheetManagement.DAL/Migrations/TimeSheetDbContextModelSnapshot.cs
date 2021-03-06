// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeSheetManagement.DAL.Data;

namespace TimeSheetManagement.DAL.Migrations
{
    [DbContext(typeof(TimeSheetDbContext))]
    partial class TimeSheetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpDOJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpEmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpPsw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MgrID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EmpID");

                    b.HasIndex("MgrID");

                    b.HasIndex("ProjectID");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.Manager", b =>
                {
                    b.Property<int>("MgrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MgrDOJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MgrEmaiID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MgrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MgrPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MgrPsw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MgrUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MgrID");

                    b.ToTable("manager");
                });

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("project");
                });

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.Employee", b =>
                {
                    b.HasOne("TimeSheetManagement.Entity.Models.Manager", "manager")
                        .WithMany()
                        .HasForeignKey("MgrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeSheetManagement.Entity.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("manager");

                    b.Navigation("project");
                });
#pragma warning restore 612, 618
        }
    }
}
