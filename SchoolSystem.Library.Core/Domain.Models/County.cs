using SchoolSystem.Library.Core.Abstractions;

namespace SchoolSystem.Library.Core.Domain.Models
{
  public class County : ICounty
  {
    public string Code { get; set; }
    public string Name { get; set; }
  }
}
