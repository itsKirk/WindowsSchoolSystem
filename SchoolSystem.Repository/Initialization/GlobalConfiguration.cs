using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Repository.Initialization
{
  public static class GlobalConfiguration
  {
    /// <summary>
    /// Gets the SqlLite database connectionstring.
    /// </summary>
    /// <returns>connectionstring</returns>
    public static string SqlLiteConnection() =>
      ConfigurationManager.ConnectionStrings["SqlLiteDB"].ConnectionString;
    /// <summary>
    /// Gets the Sql database connectionstring.
    /// </summary>
    /// <returns>connectionstring</returns>
    public static string SqlConnection() =>
      ConfigurationManager.ConnectionStrings["SqlDB"].ConnectionString;
  }
}
