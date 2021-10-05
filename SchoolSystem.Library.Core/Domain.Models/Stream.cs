using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Library.Core.Domain.Models
{
  class Stream
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Class Class { get; set; }
  }
}
