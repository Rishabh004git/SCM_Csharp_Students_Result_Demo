using Xunit;
using StudentResultsApi.Services;

namespace StudentResultsApi.Tests;

public class StudentResultTests
{
    [Fact]
    public void GetResult_ReturnsStudentAndTotal()
    {
        var service = new ResultService();

        var result = service.GetResult("Asha");

        Assert.Equal("Asha", result.Student);
        Assert.Equal(70, result.Total);
    }

    [Fact]
    public void GetResult_ReturnsDifferentStudent()
    {
        var service = new ResultService();

        var result = service.GetResult("Raj");

        Assert.Equal("Raj", result.Student);
        Assert.True(result.Total > 0);
    }

    [Fact]
    public void GetResult_ReturnsValidTotalScore()
    {
        var service = new ResultService();

        var result = service.GetResult("Asha");

        Assert.NotNull(result);
        Assert.True(result.Total >= 0, "Total score should be non-negative");
        Assert.True(result.Total <= 100, "Total score should not exceed 100");
    }
}
