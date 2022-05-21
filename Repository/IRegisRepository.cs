using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Repository
{
    public interface IRegisRepository
    {
        bool insert(string[] Param);
        List<TestDemo.Models.TBL_TRN_REGISTRATION> GetDataREGIS();
    }
}
