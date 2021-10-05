using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using SchoolSystem.Library.Core.Domain.Models;
using SchoolSystem.Repository.SqlLiteCode;
using SchoolSystem.Repository.SqlLiteCode.DataAccess;
using Xunit;

namespace Repository.Tests
{
  public class CountiesTests
  {
    [Fact]
    public void GetCounties_ValidCall()
    {
      using (var mock = AutoMock.GetLoose())
      {
        mock.Mock<ISqlLiteDataAccess>()
          .Setup(x => x.LoadData<County>("select * from Counties"))
          .Returns(GetSampleCounties());
        var cls = mock.Create<CountiesRepository>();
        //var expected = Enumerable.Any(GetSampleCounties().Result);
        //var actual = Enumerable.Any(cls.GetCounties().Result);
        //Assert.Equal(expected,actual);
        var expected = GetSampleCounties();
        var actual = cls.GetCounties();
        Assert.True(actual != null);
        Assert.Equal(expected.Result.Count, actual.Result.Count);
      }
    }
    private async Task<List<County>> GetSampleCounties()
    {
      return await
        Task.Run(() => new List<County>()
        {
                new County {Name = "Makueni", Code = "017"},
                new County {Name = "Machakos", Code = "016"},
                new County {Name = "Mombasa", Code = "001"},
                new County {Name = "Nyamira", Code = "046"}
        });
    }

    [Theory]
    [InlineData("kirk", "kirk")]
    public void InitializeCounties_ShouldInsertToSqlLiteDatabase(string one, string two)
    {
      //Arrange
      var firstActual = one;
      var secondActual = two;
      //Act

      //Assert
      Assert.Equal(firstActual, secondActual);
    }
    [Fact]
    public void InitializeCounties_ShouldInsertToSqlDatabase()
    {
      //Arrange

      //Act

      //Assert
    }
  }
}
