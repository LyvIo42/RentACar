using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EmailAuthenticatorConfiguration : IEntityTypeConfiguration<EmailAuthenticator>
{
    public void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        builder.ToTable("RefreshToken").HasKey(ao => ao.Id);

        builder.Property(ao => ao.Id).HasColumnName("Id").IsRequired();
        builder.Property(ao => ao.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(ao => ao.ActivationKey).HasColumnName("ActivationKey").IsRequired();
        builder.Property(ao => ao.IsVerified).HasColumnName("IsVerified").IsRequired();
        builder.Property(ao => ao.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ao => ao.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ao => ao.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(ao => !ao.DeletedDate.HasValue);


        builder.HasOne(ao => ao.User);

    }
}