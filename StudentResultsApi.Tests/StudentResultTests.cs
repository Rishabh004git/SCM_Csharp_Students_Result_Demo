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
}
