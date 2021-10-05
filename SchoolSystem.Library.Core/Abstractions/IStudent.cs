using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Library.Core.Abstractions
{
  public interface IStudent : IPerson
  {
    string AdmissionNumber { get; set; }
    string UPINumber { get; set; }
    bool IsActive { get; set; }

  }
}
