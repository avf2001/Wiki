# Workflow Strategies
## Trunk-Based Development (Single Branch)
## Feature Branching (GitHub Flow)
Purpose:
- For small teams
## Forking Strategy
Purpose:
- For open source projects
## Release Branching
## Git Flow
Cons:
- Too complex
## Environment Branching
Cons:
- Too complex

```shell
# Source: https://www.iamtimcorey.com/courses/git-from-start-to-finish/; Tim Corey; Section 8
1. git checkout main
2. git pull
3. git checkout -b new-branch
4. git add .
5. git commit
6. git checkout main
7. git pull
8. git checkout new-branch
9. git merge main
10. git checkout main
11. git merge new-branch
12. git pull
13. git push
14. git branch -d new-branch
```
