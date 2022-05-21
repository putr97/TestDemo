
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using TestDemo.DBLayer;
using TestDemo.Models;

namespace TestDemo.Repository
{
    public class RegisContextRepository : IRegisRepository
    {
        private readonly DBAccessContext dBAccessContext;
        private readonly IConfiguration configuration;

        public RegisContextRepository(DBAccessContext dBAccessContext, IConfiguration configuration)
        {
            this.dBAccessContext = dBAccessContext;
            this.configuration = configuration;
        }

        public List<TBL_TRN_REGISTRATION> GetDataREGIS()
        {
            return dBAccessContext.Regis_User.ToList();
        }

        public bool insert(string[] Param)
        {
            var model = new TBL_TRN_REGISTRATION()
            {
                USERNAME = Param[0],
                PASSWORD = Param[1],
                CONFIRMPASS = Param[2],
                EMAIL = Param[3],
                SEXID = Param[4],
                MARITALID = Param[5]
            };

            dBAccessContext.Regis_User.Add(model);
            var result= dBAccessContext.SaveChanges();


            if (result > 0)
            {
                return true;

            }
            return false;
        }

    }
}