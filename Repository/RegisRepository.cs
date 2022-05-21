using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using TestDemo.DBLayer;
using TestDemo.Models;

namespace TestDemo.Repository
{
    public class RegisRepository : IRegisRepository
    {
        private readonly IConfiguration configuration;
        private readonly DataAccessDB DB;

        public RegisRepository(IConfiguration configuration)
        { 
            this .configuration = configuration;
            DB = new DataAccessDB (configuration);
        }

        public List<TBL_TRN_REGISTRATION> GetDataREGIS()
        {
            return DB.GetDataREGIS();
        }

        public bool insert(string[] Param)
        {
            return DB.insertRegis(Param);
        }

    }
}
