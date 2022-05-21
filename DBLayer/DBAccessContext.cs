using TestDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.DBLayer
{
    public class DBAccessContext:DbContext
    {

        public DBAccessContext(DbContextOptions<DBAccessContext> options):base(options)
        { 
        }

        public DbSet<CrudModel> Crud_Data { get; set; }
        public DbSet<TBL_TRN_REGISTRATION> Regis_User { get; set; }

    }
}
