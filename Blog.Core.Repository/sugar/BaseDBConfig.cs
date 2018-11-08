using System;
using System.Linq;
using SqlSugar;

namespace Blog.Core.Repository.sugar
{
    public class BaseDBConfig
    {
        public static string ConnectionString = "server=.;uid=root;pwd=Ls13548274447;database=BlogDb";
        /*public BaseDBConfig()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig(){
                ConnectionString = "server=.;uid=root;pwd=Ls13548274447;database=BlogDb",
                DbType = DbType.MySql,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如何存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });
            //用来打印Sql方便你调式    
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }*/
    }
}
