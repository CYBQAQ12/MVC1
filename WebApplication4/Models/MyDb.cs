using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<WebApplication4.Models.Xueshengxinxi> Xueshengxinxis { get; set; }

        public System.Data.Entity.DbSet<WebApplication4.Models.Chengji> Chengjis { get; set; }
    }
}