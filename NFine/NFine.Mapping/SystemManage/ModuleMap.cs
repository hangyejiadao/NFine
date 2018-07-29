/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFine.Domain.Entity.SystemManage;


namespace NFine.Mapping.SystemManage
{
    public class ModuleMap : IEntityTypeConfiguration<ModuleEntity>
    {


        public void Configure(EntityTypeBuilder<ModuleEntity> builder)
        {
            builder.ToTable("Sys_Module");
            builder.HasKey(t => t.F_Id);
        }
    }
}
