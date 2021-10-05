using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Library.Core.Abstractions
{
  public interface IPerson
  {
    int Id { get; set; }
    string FirstName { get; set; }
    string MiddleName { get; set; }
    string LastName { get; set; }
    string HudumaNumber { get; set; }
    string MobileNumber { get; set; }
    Religion Religion { get; set; }
    Gender Gender { get; set; }
    string Notes { get; set; }
    string FullName();
  }
}
