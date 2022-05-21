using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Repository
{
   public interface ICrudRepository
    {
        bool insert(string[] Param);
        List<TestDemo.Models.CrudModel> GetData();
    }
}
