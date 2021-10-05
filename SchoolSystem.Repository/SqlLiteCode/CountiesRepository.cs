using System.Collections;
using Dapper;
using SchoolSystem.Library.Core.Domain.Models;
using SchoolSystem.Repository.Abstractions;
using SchoolSystem.Repository.Initialization;
using SchoolSystem.Repository.SqlCode.DataAccess;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using SchoolSystem.Repository.SqlLiteCode.DataAccess;

namespace SchoolSystem.Repository.SqlLiteCode
{
  public class CountiesRepository : ICountiesRepository
  {
    private static bool CountiesLoaded { get; set; }
    private readonly ISqlLiteDataAccess database;

    public CountiesRepository(ISqlLiteDataAccess db)
    {
      database = db;
    }
    public void LoadCounties()
    {

      if (!CountiesLoaded)
      {
        if (database.LoadData<List<County>>("select * from Counties").Result.Count > 0)
        {
          CountiesLoaded = true;
          return;
        }
      }
      else
      {
        return;
      }
      var counties = Initialization.StartUp.Counties();
      foreach (var county in counties)
      {
        database.SaveData(county, "insert_County");
      }
      CountiesLoaded = true;
    }
    public County SaveCounty(County county)
    {
      database.SaveData(county, "insert into Counties(Code, Name)Values(@Code, @Name)");
      return county;
    }

    public async Task<List<County>> GetCounties()
    {
      return await Task.Run(()=> database.LoadData<County>("select * from Counties"));
    }
  }
}
