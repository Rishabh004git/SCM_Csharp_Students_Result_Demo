# SCM C# Student Results API Demo

A deliberately small ASP.NET Core Web API created for a Software Configuration Management guest lecture.

## Technology
- C#
- .NET 8
- ASP.NET Core Minimal API
- xUnit
- Git
- GitHub Pull Request
- GitHub Actions

## Initial behavior

Run the API and call:

`GET /api/results/Asha`

The initial response is:

```json
{
  "student": "Asha",
  "total": 70
}
```

## Demo change

Add a `status` field:

- `PASS` when total >= 40
- `FAIL` when total < 40

The final response becomes:

```json
{
  "student": "Asha",
  "total": 70,
  "status": "PASS"
}
```

## Local commands

Check the .NET SDK:

```bash
dotnet --version
```

Build:

```bash
dotnet build StudentResultsApi.sln
```

Run tests:

```bash
dotnet test StudentResultsApi.Tests/StudentResultsApi.Tests.csproj
```

Run the API:

```bash
dotnet run --project StudentResultsApi
```

Then open:

`http://localhost:5000/api/results/Asha`

The actual local port may be displayed by the application when it starts.

## Recommended live SCM flow

1. Start on `main`.
2. Run the existing tests.
3. Show the current API response.
4. Create `feature/add-result-status`.
5. Modify `StudentResult` and `ResultService`.
6. Add PASS and FAIL tests.
7. Run `dotnet test`.
8. Run `git diff`.
9. Commit the change.
10. Push the branch.
11. Create a Pull Request into `main`.
12. Show the code diff.
13. Show GitHub Actions running.
14. Review/approve the PR.
15. Merge.
16. Pull `main`.
17. Run the tests again.
18. Show the final API response.

The purpose is to demonstrate SCM concepts, not C# syntax.
