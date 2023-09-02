﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityConfigurations
{
    public class BrandConfiguration:IEntityTypeConfiguration <Brand>
    {
      
        public void Configure(EntityTypeBuilder<Brand> builder)
        {

            builder.ToTable("Brands");
        }
    }
}
