using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Library.Core.Domain.Models
{
  public class Class
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher ClassTeacher { get; set; }
    public Term Term { get; set; }
    public byte Capacity { get; set; }

  }
}
