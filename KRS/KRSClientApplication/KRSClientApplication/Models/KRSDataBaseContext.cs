using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KRSServerApplication.Models
{
    public partial class KRSDataBaseContext : DbContext
    {
        public virtual DbSet<Adressee> Adressee { get; set; }
        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<CostJournal> CostJournal { get; set; }
        public virtual DbSet<Pallet> Pallet { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<SchemeType> SchemeType { get; set; }
        public virtual DbSet<Send> Send { get; set; }
        public virtual DbSet<Skin> Skin { get; set; }
        public virtual DbSet<SkinType> SkinType { get; set; }
        public virtual DbSet<SortingScheme> SortingScheme { get; set; }
        public virtual DbSet<Sorts> Sorts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5IPET5F\SQLEXPRESS;Initial Catalog=KRSDataBase;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adressee>(entity =>
            {
                entity.HasKey(e => e.IdAdressee)
                    .HasName("PK_Adressee");

                entity.Property(e => e.IdAdressee).HasColumnName("ID_Adressee");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.AdresseeLabel).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);
            });

            modelBuilder.Entity<Authorization>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_Authorization");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.UserPassword).HasMaxLength(255);
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.HasKey(e => e.IdBatch)
                    .HasName("PK_Batch");

                entity.Property(e => e.IdBatch).HasColumnName("ID_Batch");

                entity.Property(e => e.BatchStatus).HasMaxLength(255);

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.IdScheme).HasColumnName("ID_Scheme");

                entity.Property(e => e.OpeningDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.IdProvider)
                    .HasConstraintName("FK_Batch_Provider");

                entity.HasOne(d => d.IdSchemeNavigation)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.IdScheme)
                    .HasConstraintName("FK_Batch_SortingScheme");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasKey(e => e.IdConfiguration)
                    .HasName("PK_Configuration");

                entity.Property(e => e.IdConfiguration).HasColumnName("ID_Configuration");

                entity.Property(e => e.ConfigurationLabel).HasMaxLength(255);

                entity.Property(e => e.HotKey).HasMaxLength(255);


                entity.HasOne(d => d.IdTypeSkinNavigation)
                    .WithMany(p => p.Configuration)
                    .HasForeignKey(d => d.IdConfiguration)
                    .HasConstraintName("FK_SkinType_Configuration");
            });

            modelBuilder.Entity<CostJournal>(entity =>
            {
                entity.HasKey(e => e.IdCost)
                    .HasName("PK_CostJournal");

                entity.Property(e => e.IdCost).HasColumnName("ID_Cost");

                entity.Property(e => e.CostDate).HasColumnType("datetime");

                entity.Property(e => e.IdSort).HasColumnName("ID_Sort");

                entity.Property(e => e.IdTypeSkin).HasColumnName("ID_Type_Skin");

                entity.Property(e => e.SkinPrice).HasColumnType("decimal");

                entity.HasOne(d => d.IdSortNavigation)
                    .WithMany(p => p.CostJournal)
                    .HasForeignKey(d => d.IdSort)
                    .HasConstraintName("FK_CostJournal_Sorts");

                entity.HasOne(d => d.IdTypeSkinNavigation)
                    .WithMany(p => p.CostJournal)
                    .HasForeignKey(d => d.IdTypeSkin)
                    .HasConstraintName("FK_CostJournal_SkinType");
            });

            modelBuilder.Entity<Pallet>(entity =>
            {
                entity.HasKey(e => e.IdPallet)
                    .HasName("PK_Pallet");

                entity.Property(e => e.IdPallet).HasColumnName("ID_Pallet");

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.IdTypeSkin).HasColumnName("ID_Type_Skin");

                entity.Property(e => e.OpeningDate).HasColumnType("datetime");

                entity.Property(e => e.SendingDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.HasOne(d => d.IdTypeSkinNavigation)
                    .WithMany(p => p.Pallet)
                    .HasForeignKey(d => d.IdTypeSkin)
                    .HasConstraintName("FK_Pallet_SkinType");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.IdProvider)
                    .HasName("PK_Provider");

                entity.Property(e => e.IdProvider).HasColumnName("ID_Provider");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnType("decimal");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.ProviderLabel).HasMaxLength(255);
            });

            modelBuilder.Entity<SchemeType>(entity =>
            {
                entity.HasKey(e => e.IdSchemeType)
                    .HasName("PK_SchemeType");

                entity.Property(e => e.IdSchemeType).HasColumnName("ID_Scheme_Type");

                entity.Property(e => e.IdScheme).HasColumnName("ID_Scheme");

                entity.Property(e => e.IdTypeSkin).HasColumnName("ID_Type_Skin");

                entity.HasOne(d => d.IdSchemeNavigation)
                    .WithMany(p => p.SchemeType)
                    .HasForeignKey(d => d.IdScheme)
                    .HasConstraintName("FK_SchemeType_SortingScheme");

                entity.HasOne(d => d.IdTypeSkinNavigation)
                    .WithMany(p => p.SchemeType)
                    .HasForeignKey(d => d.IdTypeSkin)
                    .HasConstraintName("FK_SchemeType_SkinType");
            });

            modelBuilder.Entity<Send>(entity =>
            {
                entity.HasKey(e => e.IdSend)
                    .HasName("PK_Send");

                entity.Property(e => e.IdSend).HasColumnName("ID_Send");

                entity.Property(e => e.IdAdressee).HasColumnName("ID_Adressee");

                entity.Property(e => e.IdPallet).HasColumnName("ID_Pallet");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdAdresseeNavigation)
                    .WithMany(p => p.Send)
                    .HasForeignKey(d => d.IdAdressee)
                    .HasConstraintName("FK_Send_Adressee");

                entity.HasOne(d => d.IdPalletNavigation)
                    .WithMany(p => p.Send)
                    .HasForeignKey(d => d.IdPallet)
                    .HasConstraintName("FK_Send_Pallet");
            });

            modelBuilder.Entity<Skin>(entity =>
            {
                entity.HasKey(e => e.IdSkin)
                    .HasName("PK_Skin");

                entity.Property(e => e.IdSkin).HasColumnName("ID_Skin");

                entity.Property(e => e.IdBatch).HasColumnName("ID_Batch");

                entity.Property(e => e.IdConfiguration).HasColumnName("ID_Configuration");

                entity.Property(e => e.IdPallet).HasColumnName("ID_Pallet");

                entity.Property(e => e.IdSort).HasColumnName("ID_Sort");

                entity.Property(e => e.IdTypeSkin).HasColumnName("ID_Type_Skin");

                entity.HasOne(d => d.IdBatchNavigation)
                    .WithMany(p => p.Skin)
                    .HasForeignKey(d => d.IdBatch)
                    .HasConstraintName("FK_Skin_Batch");

                entity.HasOne(d => d.IdConfigurationNavigation)
                    .WithMany(p => p.Skin)
                    .HasForeignKey(d => d.IdConfiguration)
                    .HasConstraintName("FK_Skin_Configuration");

                entity.HasOne(d => d.IdPalletNavigation)
                    .WithMany(p => p.Skin)
                    .HasForeignKey(d => d.IdPallet)
                    .HasConstraintName("FK_Skin_Pallet");

                entity.HasOne(d => d.IdSortNavigation)
                    .WithMany(p => p.Skin)
                    .HasForeignKey(d => d.IdSort)
                    .HasConstraintName("FK_Skin_Sorts");

                entity.HasOne(d => d.IdTypeSkinNavigation)
                    .WithMany(p => p.Skin)
                    .HasForeignKey(d => d.IdTypeSkin)
                    .HasConstraintName("FK_Skin_SkinType");
            });

            modelBuilder.Entity<SkinType>(entity =>
            {
                entity.HasKey(e => e.IdTypeSkin)
                    .HasName("PK_SkinType");

                entity.Property(e => e.IdTypeSkin).HasColumnName("ID_Type_Skin");

                entity.Property(e => e.MaximumWeight).HasColumnType("decimal");

                entity.Property(e => e.MinimumWeight).HasColumnType("decimal");

                entity.Property(e => e.TypeSkinLabel).HasMaxLength(255);

                entity.Property(e => e.IdConfiguration).HasColumnName("ID_Configuration");
            }); 

            modelBuilder.Entity<SortingScheme>(entity =>
            {
                entity.HasKey(e => e.IdScheme)
                    .HasName("PK_SortingScheme");

                entity.Property(e => e.IdScheme).HasColumnName("ID_Scheme");

                entity.Property(e => e.SchemeLabel).HasMaxLength(255);
            });

            modelBuilder.Entity<Sorts>(entity =>
            {
                entity.HasKey(e => e.IdSort)
                    .HasName("PK_Sorts");

                entity.Property(e => e.IdSort)
                    .HasColumnName("ID_Sort")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sort)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}