using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Library.Core.Domain.Models;
using SchoolSystem.Library.Core.DTOs;
using SchoolSystem.Repository.Abstractions;
using SchoolSystem.Repository.SqlCode;
using SchoolSystem.Repository.SqlCode.DataAccess;

namespace SchoolSystem.Repository.Initialization
{
  public static class StartUp
  {
    private static ISettingsRepository repository = new SettingsRepository(new SqlDataAccess());
    public static IEnumerable<County> Counties() =>
      new List<County>
      {
        new County{ Code = "001", Name = "Mombasa"},
        new County{ Code = "002", Name = "Kwale"},
        new County{ Code = "003", Name = "Kilifi"},
        new County{ Code = "004", Name = "Tana River"},
        new County{ Code = "005", Name = "Lamu"},
        new County{ Code = "006", Name = "Taita-Taveta"},
        new County{ Code = "007", Name = "Garissa"},
        new County{ Code = "008", Name = "Wajir"},
        new County{ Code = "009", Name = "Mandera"},
        new County{ Code = "010", Name = "Marsabit"},
        new County{ Code = "011", Name = "Isiolo"},
        new County{ Code = "012", Name = "Meru"},
        new County{ Code = "013", Name = "Tharaka-Nithi"},
        new County{ Code = "014", Name = "Embu"},
        new County{ Code = "015", Name = "Kitui"},
        new County{ Code = "016", Name = "Machakos"},
        new County{ Code = "017", Name = "Makueni"},
        new County{ Code = "018", Name = "Nyandarua"},
        new County{ Code = "019", Name = "Nyeri"},
        new County{ Code = "020", Name = "Kirinyaga"},
        new County{ Code = "021", Name = @"Murang'a"},
        new County{ Code = "022", Name = "Kiambu"},
        new County{ Code = "023", Name = "Turkana"},
        new County{ Code = "024", Name = "West Pokot"},
        new County{ Code = "025", Name = "Samburu"},
        new County{ Code = "026", Name = "Trans-Nzoia"},
        new County{ Code = "027", Name = "Uasin Gishu"},
        new County{ Code = "028", Name = "Elgeyo-Marakwet"},
        new County{ Code = "029", Name = "Nandi"},
        new County{ Code = "030", Name = "Baringo"},
        new County{ Code = "031", Name = "Laikipia"},
        new County{ Code = "032", Name = "Nakuru"},
        new County{ Code = "033", Name = "Narok"},
        new County{ Code = "034", Name = "Kajiado"},
        new County{ Code = "035", Name = "Kericho"},
        new County{ Code = "036", Name = "Bomet"},
        new County{ Code = "037", Name = "Kakamega"},
        new County{ Code = "038", Name = "Vihiga"},
        new County{ Code = "039", Name = "Bungoma"},
        new County{ Code = "040", Name = "Busia"},
        new County{ Code = "041", Name = "Siaya"},
        new County{ Code = "042", Name = "Kisumu"},
        new County{ Code = "043", Name = "Homa Bay"},
        new County{ Code = "044", Name = "Migori"},
        new County{ Code = "045", Name = "Kisii"},
        new County{ Code = "046", Name = "Nyamira"},
        new County{ Code = "047", Name = "Nairobi"},
      };

    public static Logo GetLogo() => repository.GetLogo();
  }
}
