using Microsoft.EntityFrameworkCore;

namespace TestApplication.Data.Models
{
    public class FormAppContext : DbContext
    {
        public FormAppContext(DbContextOptions<FormAppContext> options) : base(options)
        {
        }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSector> UserSectors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sector>(entity =>
            {
                entity.ToTable("sector");

                entity.HasKey(s => s.Id).HasName("PK_sector_id");

                entity.HasIndex(s => s.SectorCode, "sector_sector_id_key").IsUnique();

                entity.Property(s => s.SectorCode).HasColumnName("sector_id").IsRequired(true);

                entity.Property(s => s.SectorParentCode).HasColumnName("sector_parent_id");

                entity.Property(s => s.SectorName).HasColumnName("sector_name").IsRequired(true);

                entity.HasData(
                  new Sector { Id = 1, SectorCode = 1, SectorName = "Manufacturing" },
                  new Sector { Id = 2, SectorCode = 19, SectorName = "Construction materials", SectorParentCode = 1 },
                  new Sector { Id = 3, SectorCode = 18, SectorName = "Electronics and Optics", SectorParentCode = 1 },
                  new Sector { Id = 4, SectorCode = 6, SectorName = "Food and Beverage", SectorParentCode = 1 },
                  new Sector { Id = 5, SectorCode = 342, SectorName = "Bakery & confectionery products", SectorParentCode = 6 },
                  new Sector { Id = 6, SectorCode = 43, SectorName = "Beverages", SectorParentCode = 6 },
                  new Sector { Id = 7, SectorCode = 42, SectorName = "Fish & fish products", SectorParentCode = 6 },
                  new Sector { Id = 8, SectorCode = 40, SectorName = "Meat & meat products", SectorParentCode = 6 },
                  new Sector { Id = 9, SectorCode = 39, SectorName = "Milk  & dairy products", SectorParentCode = 6 },
                  new Sector { Id = 10, SectorCode = 378, SectorName = "Sweets & snack food", SectorParentCode = 6 },
                  new Sector { Id = 11, SectorCode = 437, SectorName = "Other", SectorParentCode = 6 },
                  new Sector { Id = 12, SectorCode = 13, SectorName = "Furniture", SectorParentCode = 1 },
                  new Sector { Id = 13, SectorCode = 389, SectorName = "Bathroom/sauna", SectorParentCode = 13 },
                  new Sector { Id = 14, SectorCode = 385, SectorName = "Bedroom", SectorParentCode = 13 },
                  new Sector { Id = 15, SectorCode = 390, SectorName = "Children’s room", SectorParentCode = 13 },
                  new Sector { Id = 16, SectorCode = 98, SectorName = "Kitchen ", SectorParentCode = 13 },
                  new Sector { Id = 17, SectorCode = 101, SectorName = "Living room", SectorParentCode = 13 },
                  new Sector { Id = 18, SectorCode = 392, SectorName = "Office", SectorParentCode = 13 },
                  new Sector { Id = 19, SectorCode = 341, SectorName = "Outdoor", SectorParentCode = 13 },
                  new Sector { Id = 20, SectorCode = 99, SectorName = "Project furniture", SectorParentCode = 13 },
                  new Sector { Id = 21, SectorCode = 394, SectorName = "Other (Furniture)", SectorParentCode = 13 },
                  new Sector { Id = 22, SectorCode = 12, SectorName = "Machinery ", SectorParentCode = 1 },
                  new Sector { Id = 23, SectorCode = 94, SectorName = "Machinery components", SectorParentCode = 12 },
                  new Sector { Id = 24, SectorCode = 91, SectorName = "Machinery equipment/tools", SectorParentCode = 12 },
                  new Sector { Id = 25, SectorCode = 224, SectorName = "Manufacture of machinery", SectorParentCode = 12 },
                  new Sector { Id = 26, SectorCode = 97, SectorName = "Maritime", SectorParentCode = 12 },
                  new Sector { Id = 27, SectorCode = 271, SectorName = "Aluminium and steel workboats", SectorParentCode = 97 },
                  new Sector { Id = 28, SectorCode = 269, SectorName = "Boat/Yacht building", SectorParentCode = 97 },
                  new Sector { Id = 29, SectorCode = 230, SectorName = "Ship repair and conversion", SectorParentCode = 97 },
                  new Sector { Id = 30, SectorCode = 93, SectorName = "Metal structures", SectorParentCode = 12 },
                  new Sector { Id = 31, SectorCode = 227, SectorName = "Repair and maintenance service", SectorParentCode = 12 },
                  new Sector { Id = 32, SectorCode = 508, SectorName = "Other", SectorParentCode = 12 },
                  new Sector { Id = 33, SectorCode = 11, SectorName = "Metalworking", SectorParentCode = 1 },
                  new Sector { Id = 34, SectorCode = 67, SectorName = "Construction of metal structures", SectorParentCode = 11 },
                  new Sector { Id = 35, SectorCode = 263, SectorName = "Houses and buildings", SectorParentCode = 11 },
                  new Sector { Id = 36, SectorCode = 267, SectorName = "Metal products", SectorParentCode = 11 },
                  new Sector { Id = 37, SectorCode = 542, SectorName = "Metal works", SectorParentCode = 11 },
                  new Sector { Id = 38, SectorCode = 75, SectorName = "CNC-machining", SectorParentCode = 542 },
                  new Sector { Id = 39, SectorCode = 62, SectorName = "Forgings, Fasteners", SectorParentCode = 542 },
                  new Sector { Id = 40, SectorCode = 69, SectorName = "Gas, Plasma, Laser cutting", SectorParentCode = 542 },
                  new Sector { Id = 41, SectorCode = 66, SectorName = "MIG, TIG, Aluminum welding", SectorParentCode = 542 },
                  new Sector { Id = 42, SectorCode = 9, SectorName = "Plastic and Rubber", SectorParentCode = 1 },
                  new Sector { Id = 43, SectorCode = 54, SectorName = "Packaging", SectorParentCode = 9 },
                  new Sector { Id = 44, SectorCode = 556, SectorName = "Plastic goods", SectorParentCode = 9 },
                  new Sector { Id = 45, SectorCode = 559, SectorName = "Plastic processing technology", SectorParentCode = 9 },
                  new Sector { Id = 46, SectorCode = 55, SectorName = "Blowing", SectorParentCode = 559 },
                  new Sector { Id = 47, SectorCode = 57, SectorName = "Moulding", SectorParentCode = 559 },
                  new Sector { Id = 48, SectorCode = 53, SectorName = "Plastics welding and processing", SectorParentCode = 559 },
                  new Sector { Id = 49, SectorCode = 560, SectorName = "Plastic profiles", SectorParentCode = 9 },
                  new Sector { Id = 50, SectorCode = 5, SectorName = "Printing ", SectorParentCode = 1 },
                  new Sector { Id = 51, SectorCode = 148, SectorName = "Advertising ", SectorParentCode = 5 },
                  new Sector { Id = 52, SectorCode = 150, SectorName = "Book/Periodicals printing", SectorParentCode = 5 },
                  new Sector { Id = 53, SectorCode = 145, SectorName = "Labelling and packaging printing", SectorParentCode = 5 },
                  new Sector { Id = 54, SectorCode = 7, SectorName = "Textile and Clothing", SectorParentCode = 1 },
                  new Sector { Id = 55, SectorCode = 44, SectorName = "Clothing", SectorParentCode = 7 },
                  new Sector { Id = 56, SectorCode = 45, SectorName = "Textile", SectorParentCode = 7 },
                  new Sector { Id = 57, SectorCode = 8, SectorName = "Wood", SectorParentCode = 1 },
                  new Sector { Id = 58, SectorCode = 51, SectorName = "Wooden building materials", SectorParentCode = 8 },
                  new Sector { Id = 59, SectorCode = 47, SectorName = "Wooden houses", SectorParentCode = 8 },
                  new Sector { Id = 60, SectorCode = 337, SectorName = "Other", SectorParentCode = 8 },
                  new Sector { Id = 61, SectorCode = 2, SectorName = "Service" },
                  new Sector { Id = 62, SectorCode = 25, SectorName = "Business services", SectorParentCode = 2 },
                  new Sector { Id = 63, SectorCode = 35, SectorName = "Engineering", SectorParentCode = 2 },
                  new Sector { Id = 64, SectorCode = 28, SectorName = "Information Technology and Telecommunications", SectorParentCode = 2 },
                  new Sector { Id = 65, SectorCode = 581, SectorName = "Data processing, Web portals, E-marketing", SectorParentCode = 28 },
                  new Sector { Id = 66, SectorCode = 576, SectorName = "Programming, Consultancy", SectorParentCode = 28 },
                  new Sector { Id = 67, SectorCode = 121, SectorName = "Software, Hardware", SectorParentCode = 28 },
                  new Sector { Id = 68, SectorCode = 122, SectorName = "Telecommunications", SectorParentCode = 28 },
                  new Sector { Id = 69, SectorCode = 22, SectorName = "Tourism", SectorParentCode = 2 },
                  new Sector { Id = 70, SectorCode = 141, SectorName = "Translation services", SectorParentCode = 2 },
                  new Sector { Id = 71, SectorCode = 21, SectorName = "Transport and Logistics", SectorParentCode = 2 },
                  new Sector { Id = 72, SectorCode = 111, SectorName = "Air", SectorParentCode = 21 },
                  new Sector { Id = 73, SectorCode = 114, SectorName = "Rail", SectorParentCode = 21 },
                  new Sector { Id = 74, SectorCode = 112, SectorName = "Road", SectorParentCode = 21 },
                  new Sector { Id = 75, SectorCode = 113, SectorName = "Water", SectorParentCode = 21 },
                  new Sector { Id = 76, SectorCode = 3, SectorName = "Other" },
                  new Sector { Id = 77, SectorCode = 37, SectorName = "Creative industries", SectorParentCode = 3 },
                  new Sector { Id = 78, SectorCode = 29, SectorName = "Energy technology", SectorParentCode = 3 },
                  new Sector { Id = 79, SectorCode = 33, SectorName = "Environment", SectorParentCode = 3 }
              );
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(s => s.Id).ValueGeneratedOnAdd().HasColumnName("id");

                entity.HasKey(s => s.Id).HasName("PK_user_id");

                entity.Property(s => s.Name).HasColumnName("name").IsRequired();

                entity.Property(s => s.AgreedToTerms).HasColumnName("agreed_to_terms").IsRequired();

                entity.Property(s => s.AddedAt).HasColumnName("added_time").IsRequired();

                entity.Property(s => s.UpdatedAt).HasColumnName("updated_time");

                entity.Property(s => s.SessionID).HasColumnName("session_id").IsRequired();
            });

            modelBuilder.Entity<UserSector>(entity =>
            {
                entity.ToTable("user_sector");

                entity.Property(s => s.Id).ValueGeneratedOnAdd().HasColumnName("id");

                entity.HasKey(s => s.Id).HasName("PK_user_sector_key");

                entity.Property(s => s.UserId).HasColumnName("user_id").IsRequired();

                entity.Property(s => s.SectorId).HasColumnName("sector_id").IsRequired();

                entity.HasOne(d => d.User)
                .WithMany(p => p.UserSector)
                .HasPrincipalKey(p => p.Id)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("user_sector_user_id_fkey");

                entity.HasOne(d => d.Sector)
                .WithMany(p => p.UserSector)
                .HasPrincipalKey(p => p.Id)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("user_sector_sector_id_fkey");
            });
        }
    }
}
