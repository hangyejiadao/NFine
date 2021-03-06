﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFine.Domain.Entity.SystemSecurity;
 

namespace NFine.Mapping.SystemSecurity
{
    public class DbBackupMap : IEntityTypeConfiguration<DbBackupEntity>
    {
       

        public void Configure(EntityTypeBuilder<DbBackupEntity> builder)
        {
            builder.ToTable("Sys_DbBackup");
            builder.HasKey(t => t.F_Id);
        }
    }
}
