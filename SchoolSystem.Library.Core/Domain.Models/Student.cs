using System;
using SchoolSystem.Library.Core.Abstractions;

namespace SchoolSystem.Library.Core.Domain.Models
{
  public class Student : IStudent
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string HudumaNumber { get; set; }
    public string UPINumber { get; set; }
    public string MobileNumber { get; set; }
    public string AdmissionNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime WithdrawalDate { get; set; }
    public DateTime GraduationDate { get; set; }
    public bool IsActive { get; set; } = true;
    public Religion Religion { get; set; }
    public Gender Gender { get; set; }
    public StudentStatus Status { get; set; }
    public string Notes { get; set; }

    public string FullName() => string.IsNullOrEmpty(MiddleName) ?
      $"{FirstName.ToUpper()} {LastName.ToUpper()}" : $"{FirstName.ToUpper()} {MiddleName.Substring(0, 1).ToUpper()}. {LastName.ToUpper()}";

  }
}
