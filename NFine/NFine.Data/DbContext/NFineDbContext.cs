﻿/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using System;

using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace NFine.Data
{
    public class NFineDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
      
          
        //public NFineDbContext()
        //    : base("NFineDbContext")
        //{
        //    this.Configuration.AutoDetectChangesEnabled = false;
        //    this.Configuration.ValidateOnSaveEnabled = false;
        //    this.Configuration.LazyLoadingEnabled = false;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("NFine.Data.DLL", "NFine.Mapping.DLL").Replace("file:///", "");
        //    Assembly asm = Assembly.LoadFile(assembleFileName);
        //    var typesToRegister = asm.GetTypes()
        //    .Where(type => !String.IsNullOrEmpty(type.Namespace))
        //    .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));
        //    foreach (var type in typesToRegister)
        //    {
        //        dynamic configurationInstance = Activator.CreateInstance(type);
        //        modelBuilder.ApplyConfiguration(configurationInstance);
        //    }
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("NFine.Data.DLL", "NFine.Mapping.DLL").Replace("file:///", "");
            Assembly asm = Assembly.LoadFile(assembleFileName);
            var typesToRegister = asm.GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
    
        }
    }
}