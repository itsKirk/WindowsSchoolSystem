using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Library.Core;
using SchoolSystem.Library.Core.Abstractions;
using SchoolSystem.Library.Core.Domain.Models;
using SchoolSystem.Repository.Abstractions;
using SchoolSystem.Repository.SqlCode;
using SchoolSystem.Repository.SqlCode.DataAccess;
using SchoolSystem.Repository.SqlLiteCode;

namespace SchoolSystem.Core.Domain.Factory
{
  internal static class Factory
  {
    internal static ICounty CreateCounty() => new County();
    internal static ICompany CreateSchool() => new Company();
    internal static IStudent CreateStudent() => new Student();
    internal static ITeacher CreateTeacher() => new Teacher();
    internal static IGuardian CreateGuardian() => new Guardian();
    internal static List<string> Titles() => Enum.GetNames(typeof(Title)).ToList();
    internal static List<string> Religions() => Enum.GetNames(typeof(Religion)).ToList();
    internal static List<string> EmploymentTypes() => Enum.GetNames(typeof(EmploymentType)).ToList();
    internal static List<string> Employers() => Enum.GetNames(typeof(Employer)).ToList();
    internal static List<string> Genders() => Enum.GetNames(typeof(Gender)).ToList();
    internal static List<string> EducationLevels() => Enum.GetNames(typeof(EducationLevel)).ToList();
    internal static List<string> StudentStatuses() => Enum.GetNames(typeof(StudentStatus)).ToList();
    internal static ISettingsRepository SettingsRepository() => new SettingsRepository(new SqlDataAccess());
  }
}
