namespace Ncma.Repository.Models
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SeedData;

    public class NcmaContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<CertificateType> CertificateTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Dojo> Dojos { get; set; }
        public virtual DbSet<DojoInstructor> DojoInstructors { get; set; }
        public virtual DbSet<InstructorType> InstructorTypes { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers {get; set;}

        public NcmaContext()
        {
        }

        public NcmaContext(DbContextOptions<NcmaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=s05.winhost.com;Database=DB_4170_ncma;user id=DB_4170_ncma_user;password=t3l1k0;");
                optionsBuilder.UseSqlServer("Server=s14.winhost.com;Database=DB_4170_ncmav2;user id=DB_4170_ncmav2_user;password=t3l1k0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CertificateType>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dojo>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DojoInstructor>(entity => { });

            modelBuilder.Entity<InstructorType>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.DateInactive).HasColumnType("date");

                entity.Property(e => e.DateJoined).HasColumnType("date");

                entity.Property(e => e.DateLastPaid).HasColumnType("date");

                entity.Property(e => e.DateOfRank).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RankText)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ThruDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateAbbrev)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>().HasData(StateSeedData.SeedData);
            modelBuilder.Entity<MemberType>().HasData(MemberTypeSeedData.SeedData);
            modelBuilder.Entity<CertificateType>().HasData(CertificateTypeSeedData.SeedData);
            modelBuilder.Entity<Country>().HasData(CountrySeedData.SeedData);
            modelBuilder.Entity<InstructorType>().HasData(InstructorTypeSeedData.SeedData);

        }
    }
}