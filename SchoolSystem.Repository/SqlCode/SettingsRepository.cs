using SchoolSystem.Library.Core.DTOs;
using SchoolSystem.Repository.Abstractions;
using SchoolSystem.Repository.SqlCode.DataAccess;
using System.Linq;

namespace SchoolSystem.Repository.SqlCode
{
  public class SettingsRepository : ISettingsRepository
  {
    private readonly ISqlDataAccess database;

    public SettingsRepository(ISqlDataAccess db)
    {
      database = db;
    }
    public void SaveLogo(Logo logo)
    {
      database.SaveData(logo, "insert_Logo");
    }

    public Logo GetLogo() => database
      .LoadData<Logo>("get_Logo")
      .FirstOrDefault();

  }
}
