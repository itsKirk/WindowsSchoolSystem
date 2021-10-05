using SchoolSystem.Library.Core.Domain.Models;
using SchoolSystem.Repository.Abstractions;
using SchoolSystem.Repository.SqlCode.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolSystem.Repository.SqlCode
{
  public class CountiesSqlRepository : ICountiesRepository
  {
    private static bool CountiesLoaded { get; set; }
    private readonly ISqlDataAccess database;

    public CountiesSqlRepository(ISqlDataAccess db)
    {
      database = db;
    }
    public County SaveCounty(County county)
    {
      database.SaveData(county, "");
      return county;
    }
    public void LoadCounties()
    {

      if (!CountiesLoaded)
      {
        if (database.LoadData<List<County>>("get_Counties").Count > 0)
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
    public async Task<List<County>> GetCounties()
    {
      return await Task.Run(()=>database.LoadData<County>("get_Counties"));
    }
  }
}