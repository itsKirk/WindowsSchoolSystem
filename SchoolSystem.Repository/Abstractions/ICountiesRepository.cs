using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Library.Core.Domain.Models;

namespace SchoolSystem.Repository.Abstractions
{
  public interface ICountiesRepository
  {
    void LoadCounties();
    County SaveCounty(County county);
    Task<List<County>> GetCounties();
  }
}
