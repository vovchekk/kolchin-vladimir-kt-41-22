using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VladimirKolchinKt_41_22.Models;

namespace VladimirKolchinKt_41_22.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private const string TableName = "cd_post";

        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.PostId)
                   .HasName($"pk_{TableName}_post_id");

            builder.Property(p => p.PostId)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasColumnName("c_post_name")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(200)
                   .HasComment("Название должности");

            builder.HasMany(s => s.Teachers)
                   .WithOne(t => t.Post)
                   .HasForeignKey(t => t.PostId)
                   .HasConstraintName($"fk_{TableName}_teacher_id");
        }
    }
}
