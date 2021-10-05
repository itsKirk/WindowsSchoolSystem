namespace SchoolSystem.Library.Core.Abstractions
{
  public interface ITeacher : IPerson, ITitleable
  {
    Employer Employer { get; set; }
    EducationLevel EducationLevel { get; set; }
    string JobTitle { get; set; }
    EmploymentType EmploymentType { get; set; }
  }
}