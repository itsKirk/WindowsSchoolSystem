using Dapper;
using SchoolSystem.Repository.Initialization;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace SchoolSystem.Repository.SqlCode.DataAccess
{
  public class SqlDataAccess : ISqlDataAccess
  {

    public List<T> LoadData<T>(string sql)
    {
      using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
      {
        var output = connection.Query<T>(sql, new DynamicParameters());
        return output.ToList();
      }
    }
    public void SaveData<T>(T entity, string storedProcedure)
    {
      using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
      {
        connection.Execute(storedProcedure,  entity, commandType: CommandType.StoredProcedure);
      }
    }
    public void UpdateData<T>(T entity, string sql)
    {
      using (IDbConnection connection = new SqlConnection(LoadConnectionString()))
      {
        connection.Execute(sql, entity);
      }
    }
    private string LoadConnectionString()
      => GlobalConfiguration.SqlConnection();
  }
}
