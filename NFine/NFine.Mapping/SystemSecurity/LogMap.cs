/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using NFine.Domain.Entity.SystemSecurity; 
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NFine.Mapping.SystemSecurity
{
    public class LogMap : IEntityTypeConfiguration<LogEntity>
    {
       

        public void Configure(EntityTypeBuilder<LogEntity> builder)
        {
            builder.ToTable("Sys_Log");
            builder.HasKey(t => t.F_Id);
        }
    }
}
