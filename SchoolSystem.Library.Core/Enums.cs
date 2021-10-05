using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Library.Core
{
  public enum Religion
  {
    Christian=1, Muslim, Other
  }

  public enum StudentStatus
  {
    Active =1,
    ReEnrollment,
    Inactive,
    NewEnrollment,
    Alumnus
  }
  public enum EmploymentType
  {
    FullTime=1,
    PartTime
  }
  public enum Gender
  {
    Female=1, Male, Other
  }
  public enum Title
  {
    Mr = 1,
    Mrs,
    Miss,
    Dr,
    Prof
  }
  public enum EducationLevel
  {
    Masters = 1,
    Degree,
    HND,
    Diploma,
    Certificate
  }
  public enum Employer
  {
    TSC = 1,
    PSC,
    BOM
  }
}
