using StudentResultsApi.Models;

namespace StudentResultsApi.Services;

public class ResultService
{
    public StudentResult GetResult(string student)
    {
        // Existing controlled behavior:
        // A real application could retrieve this from a database.
        return new StudentResult
        {
            Student = student,
            Total = 70
        };
    }
}
