using System;

namespace SchoolSystem.Library.Core.Domain.Models
{
  public interface ICompany
  {
    string Name { get; set; }
    string Motto { get; set; }
    string Currency { get; set; }
    string Logo { get; set; }
    string Address { get; set; }
    string PhoneNumber { get; set; }
    string EmailAddress { get; set; }
    string Website { get; set; }
    string Language { get; set; }
    DateTime Year { get; set; }
    byte Term { get; set; }
    string StudentPrefix { get; set; }
  }
}