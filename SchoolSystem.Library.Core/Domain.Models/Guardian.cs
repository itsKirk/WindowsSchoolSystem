using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Library.Core.Abstractions;

namespace SchoolSystem.Library.Core.Domain.Models
{
  public class Guardian : IGuardian
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string HudumaNumber { get; set; }
    public string MobileNumber { get; set; }
    public Religion Religion { get; set; }
    public Gender Gender { get; set; }
    public string Notes { get; set; }
    public Title Title { get; set; }
    public string HomeAddress { get; set; }
    public string WorkAddress { get; set; }
    public string FullName() => string.IsNullOrEmpty(MiddleName) ?
      $"{Title}. {FirstName.ToUpper()} {LastName.ToUpper()}" : $"{Title}. {FirstName.ToUpper()} {MiddleName.Substring(0, 1).ToUpper()}. {LastName.ToUpper()}";

  }
}
