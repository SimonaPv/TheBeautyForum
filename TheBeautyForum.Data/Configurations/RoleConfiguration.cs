﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(RolesData());
        }

        private ICollection<Role> RolesData()
        {
            var data = new HashSet<Role>();

            var role = new Role()
            {
                Id = Guid.Parse("5a322cf5-7101-4d4a-9e08-16382fc0a641\r\n"),
                Name = "User",
                NormalizedName = "User".ToUpper(),
                ConcurrencyStamp = "e8393d91-9ede-44d6-bdfb-7fecba284cbf"
            };
            data.Add(role);

            role = new Role()
            {
                Id = Guid.Parse("56bdecaf-285f-4a8e-b650-8bc997be759d"),
                Name = "Administrator",
                NormalizedName = "Administrator".ToUpper(),
                ConcurrencyStamp = "a778cea8-08b3-42c0-9e21-340e9a082042"
            };
            data.Add(role);

            return data;
        }
    }
}