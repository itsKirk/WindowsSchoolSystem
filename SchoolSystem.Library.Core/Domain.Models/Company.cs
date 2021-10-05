using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Library.Core.Domain.Models
{
  public class Company : ICompany
  {
    public string Name { get; set; }
    public string Motto { get; set; }
    public string Currency { get; set; }
    public string Logo { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public string Website { get; set; }
    public string Language { get; set; }
    public DateTime Year { get; set; }
    public byte Term { get; set; }
    public string StudentPrefix { get; set; }

  }
}
