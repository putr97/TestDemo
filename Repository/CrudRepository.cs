using TestDemo.DBLayer;
using TestDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Repository
{
    public class CrudRepository : ICrudRepository
    {
        private readonly IConfiguration configuration;
        private readonly DataAccessDB DB;

        public CrudRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.DB = new DataAccessDB(configuration); 
        }
        public List<CrudModel> GetData()
        {
            return DB.GetData();
        }

        public bool insert(string[] Param)
        {

            return DB.insert(Param);

        }


    }
}
