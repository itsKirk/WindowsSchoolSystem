using SchoolSystem.Library.Core.DTOs;

namespace SchoolSystem.Repository.Abstractions
{
  public interface ISettingsRepository
  {
    void SaveLogo(Logo logo );
    Logo GetLogo();
  }
}