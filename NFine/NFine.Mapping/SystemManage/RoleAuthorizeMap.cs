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
    public class RoleAuthorizeMap : IEntityTypeConfiguration<RoleAuthorizeEntity>
    {
     

        public void Configure(EntityTypeBuilder<RoleAuthorizeEntity> builder)
        {
            builder.ToTable("Sys_RoleAuthorize");
            builder.HasKey(t => t.F_Id);
        }
    }
}
