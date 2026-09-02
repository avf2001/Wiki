# .NET

## .NET Claude Kit
[Github](https://github.com/codewithmukesh/dotnet-claude-kit)
[Site](https://codewithmukesh.com)

## dotnet-agent-skills

## Workflows

### The "Filesystem-as-State-Machine" Workflow
One recommended workflow pattern uses a structured, agentic loop that treats the filesystem as the source of truth :

1. **Research & Plan**: `/dotnet:research` spawns specialist agents (e.g., `ef-schema-designer`, `api-architect`) to analyze requirements. Their outputs are compressed into a consolidated `plan.md` by a "context-supervisor" to save token budget.

2. **Work**: `work` reads the plan, routes tasks via annotations (`[ef]`, `[api]`, `[test]`), updates `progress.md`, and writes decisions to `scratchpad.md`.

3. **Review**: `/dotnet:review` runs parallel reviewers (C# idioms, security, tests, Iron Laws). The `iron-law-judge` flags non-negotiable rules—like `decimal` for money, `await` over `.Result`, and flowing `CancellationToken` through async calls .

4. **Learn**: Captures surprising bug fixes to `.claude/solutions/` for future `/dotnet:investigate` lookups.

### "Plan → Implement → Validate" Loop
Another proven approach uses worktrees for parallel work :

1. **Plan**: Define the feature spec (PRD).

2. **Implement**: A dedicated `implementer` agent edits files and builds.

3. **Validate**: A `validator` agent checks against standards and runs tests.

4. **Review**: Read-only agents (`architect-backend`, `security-auditor-backend`) inspect for rule violations without editing, providing an adversarial safety net .
