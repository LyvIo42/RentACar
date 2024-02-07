using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable("RefreshToken").HasKey(rf => rf.Id);

        builder.Property(rf => rf.Id).HasColumnName("Id").IsRequired();
        builder.Property(rf => rf.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(rf => rf.Token).HasColumnName("Token").IsRequired();
        builder.Property(rf => rf.Expires).HasColumnName("Expires").IsRequired();
        builder.Property(rf => rf.CreatedByIp).HasColumnName("CreatedByIp").IsRequired();
        builder.Property(rf => rf.Revoked).HasColumnName("Revoked").IsRequired();
        builder.Property(rf => rf.RevekodByIp).HasColumnName("RevokedByIp").IsRequired();
        builder.Property(rf => rf.ReplecedByToken).HasColumnName("ReplacedByToken").IsRequired();
        builder.Property(rf => rf.ReasonRevoked).HasColumnName("ReasonRevoked").IsRequired();




        builder.HasQueryFilter(rf => !rf.DeletedDate.HasValue);


        builder.HasOne(rf => rf.User);

    }
}
