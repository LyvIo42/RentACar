using Application;
using Core.Security.Entities;
using Core.Security.Hashing;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;



public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperaitonClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasMany(oc => oc.UserOperationClaims);

        //builder.HasData(_seeds);

    }

    //private IEnumerable<OperationClaim> _seeds()
    //{
    //    get

    //     { 
    //        int id = 0;
    //        yield return new OperationClaim { Id = ++id, Name = GeneralOperationClaim.Admin };
    //        #region fature operation Claim
    //        IEnumerable<Type> fatureOpertaionClaimsTypes = Assembly
    //        .GetAssembly(typeof(ApplicationServiceRegistration))!
    //        .GetTypes()
    //        .Where(
    //                type =>
    //                (type.Namespace?.Contains("fatures") == true)
    //              && (type.Namespace?.Contains("Constans") == true)
    //              && type.IsClass
    //              && type.Name.EndsWith("OperationClaims")
    //              );

    //        foreach (Type type in featureOperationClaimsTypes)
    //        {
    //            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Static);
    //            IEnumerable<string> typeFieldsValues = typeFieldsValues.Select(field => field.GetValue(null)!.ToString);

    //            IEnumerable<OperationClaim> featuresOperationClaimsToAdd = typeFieldsValues.Select(
    //                value => new OperationClaim { Id = ++id, Name = value }
    //                );
    //            foreach (OperationClaim featureOperationClaim in featuresOperationClaimsToAdd)
    //                yield return featureOperationClaim;



    //        }
    //        #endregion


    //    }
       
}
