using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SchoolSystem.Repository.Initialization;

namespace SchoolSystem.Repository.SqlLiteCode.DataAccess
{
  public class SqlLiteDataAccess : ISqlLiteDataAccess
  {
    public  async Task<List<T>> LoadData<T>(string sql)
    {
      using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
      {
        var output = await cnn.QueryAsync<T>(sql, new DynamicParameters());
        return output.ToList();
      }
    }
    public async Task SaveData<T>(T county, string sql)
    {
      using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
      {
        await cnn.ExecuteAsync(sql, county);
      }
    }
    public void UpdateData<T>(T county, string sql)
    {
      using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
      {
        cnn.Execute(sql, county);
      }
    }
    private string LoadConnectionString()
      => GlobalConfiguration.SqlLiteConnection();
  }
}
