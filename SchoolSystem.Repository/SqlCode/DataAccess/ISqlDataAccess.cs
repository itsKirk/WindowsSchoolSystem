using System.Collections.Generic;

namespace SchoolSystem.Repository.SqlCode.DataAccess
{
  public interface ISqlDataAccess
  {
    List<T> LoadData<T>(string sql);
    void SaveData<T>(T entity, string sql);
    void UpdateData<T>(T entity, string sql);
  }
}
