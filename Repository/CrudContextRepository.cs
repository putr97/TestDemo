using TestDemo.DBLayer;
using TestDemo.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Repository
{
    public class CrudContextRepository : ICrudRepository
    {
        private readonly DBAccessContext dBAccessContext;
        private readonly IConfiguration configuration;

        public CrudContextRepository(DBAccessContext dBAccessContext,IConfiguration configuration)
        {
            this.dBAccessContext = dBAccessContext;
            this.configuration = configuration;
        }
        public  List<CrudModel> GetData()
        {
           return dBAccessContext.Crud_Data.ToList();
        }

        public bool insert(string[] Param)
        {
            var model = new CrudModel()
            {
                Name = Param[0],
                City = Param[1],
                InsertDate = System.DateTime.Now,
                FatherName= Param[3]

            };
          
         dBAccessContext.Crud_Data.Add(model);
           var result= dBAccessContext.SaveChanges();

            if (result>0)
            {
                return true;
            }     
            return false;
        }
    }
}
