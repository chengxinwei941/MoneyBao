using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class OrmBll<T> where T : new()
    {
        OrmHelper<T> ormHelper = new OrmHelper<T>();
        public List<T> Select(T t)
        {
            return ormHelper.Select(t);
        }
    }
}
