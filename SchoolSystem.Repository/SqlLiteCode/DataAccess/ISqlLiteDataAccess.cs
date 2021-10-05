using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolSystem.Library.Core.Domain.Models;

namespace SchoolSystem.Repository.SqlLiteCode.DataAccess
{
  public interface ISqlLiteDataAccess
  {
    Task<List<T>> LoadData<T>(string sql);
    Task SaveData<T>(T county, string sql);
    void UpdateData<T>(T county, string sql);
  }
}
