using SchoolSystem.Library.Core.Abstractions;

namespace SchoolSystem.Library.Core.Abstractions
{
  public interface IGuardian : IPerson, ITitleable
  {
    string HomeAddress { get; set; }
    string WorkAddress { get; set; }
  }
}