/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using NFine.Domain.Entity.SystemManage;
 
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NFine.Mapping.SystemManage
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        

        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Sys_User");
            builder.HasKey(t => t.F_Id);
        }
    }
}
