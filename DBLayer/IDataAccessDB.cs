using TestDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.DBLayer
{
  public  interface IDataAccessDB
    {
        bool insert(string[] Param);
        List<CrudModel> GetData();

        bool insertRegis(string[] Param);
        List<TBL_TRN_REGISTRATION> GetDataREGIS();

    }
}
