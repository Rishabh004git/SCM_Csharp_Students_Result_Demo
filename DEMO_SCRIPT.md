# 18-Minute Live Demo Script

## 0–2 min — Establish the baseline

Say:

> I am starting with the main branch. This represents our current controlled state.

Commands:

```bash
git status
git branch
dotnet test StudentResultsApi.Tests/StudentResultsApi.Tests.csproj
```

Show the current API response.

Say:

> Before changing anything, I have established the current state and confirmed that the existing tests pass.

## 2–4 min — Introduce the change

Say:

> We have received a requirement to show PASS or FAIL in the result response. I will not change main directly.

Create:

```bash
git checkout -b feature/add-result-status
```

This demonstrates controlled change.

## 4–7 min — Implement

Modify `StudentResult.cs`:

```csharp
public string Status { get; set; } = string.Empty;
```

Modify `ResultService.cs`:

```csharp
var total = 70;

return new StudentResult
{
    Student = student,
    Total = total,
    Status = total >= 40 ? "PASS" : "FAIL"
};
```

Add tests for PASS and FAIL.

## 7–9 min — Verify

Run:

```bash
dotnet test StudentResultsApi.Tests/StudentResultsApi.Tests.csproj
```

Then:

```bash
git diff
```

Say:

> The change is not considered ready simply because the code compiles. We have evidence from automated tests.

## 9–11 min — Record the change

```bash
git status
git add .
git commit -m "Add pass fail status to student results"
git log --oneline --max-count=5
```

Say:

> The commit gives us a recorded point in configuration history.

## 11–14 min — Push and Pull Request

Add your GitHub remote if necessary:

```bash
git remote add origin <YOUR-REPOSITORY-URL>
```

Then:

```bash
git push -u origin feature/add-result-status
```

Open GitHub and create a PR:

Title:
`Add PASS/FAIL status to student results`

Description:
`Adds PASS/FAIL status based on total marks and includes automated coverage for PASS and FAIL.`

## 14–16 min — CI and review

Show the PR diff.

Show GitHub Actions running.

Say:

> This is where SCM and CI/CD connect. The proposed configuration change is automatically validated before it becomes part of main.

## 16–18 min — Merge and prove the result

Merge the PR.

Then:

```bash
git checkout main
git pull
dotnet test StudentResultsApi.Tests/StudentResultsApi.Tests.csproj
```

Run the API and show:

```json
{
  "student": "Asha",
  "total": 70,
  "status": "PASS"
}
```

Close with:

> We have just seen requirement, configuration change, version history, verification, review, CI and controlled integration as one SCM workflow.
