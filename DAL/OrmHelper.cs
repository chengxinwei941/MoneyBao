using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DateModel;
using Dapper;


namespace DAL
{
    public class OrmHelper <T> where T:new()
    {
        private string GetSelectSql(T t)
        {
            Type type = typeof(T);
            string TableName = type.Name;
            string Zd = string.Join(",",type.GetProperties().Select(p=>p.Name));
            string sql = $"select {Zd} from {TableName}";
            return sql;
        }
        public List<T> Select(T t)
        {
            string sql = GetSelectSql(t);
            return ER(sql);
            
        }
        private List<T> ER(string sql)
        {
            using (SqlConnection conn=new SqlConnection("Data Source=.;Initial Catalog=Day02;Integrated Security=True"))
            {
                return conn.Query<T>(sql).ToList();
            }
        }
    }
}
