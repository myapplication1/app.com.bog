﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace app_com_bog.Data
{
    public class _DbContext: DbContext
    {
    }
}


using System;

namespace app_com_bog.Data
{

    public class _DbContext : DbContext

    {

        public _DbContext()

          : base("DefaultConnection")

        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }



        public DbSet<tb_sales_transactions> tb_sales_transactions { get; set; }
        public DbSet<tb_purchases_transactions> tb_purchases_transactions { get; set; }



    }
}