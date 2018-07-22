using System;
using System.Collections.Generic;
using System.Text;

namespace NFine.Data.DbContext
{
    public class NFineDbContextFactory
    {
        private NFineDbContext Instance;

        public NFineDbContext CreateInstance()
        {
            //Microsoft.EntityFrameworkCore.DbContext dbContext = (Microsoft.EntityFrameworkCore.DbContext)CallContext.GetData("dbContext");
            //if (dbContext == null)
            //{
            //    dbContext = new NFineDbContext();
            //    CallContext.SetData("dbContext", dbContext);
            //}
            //return dbContext;
            return new NFineDbContext();
        }

    }
}
