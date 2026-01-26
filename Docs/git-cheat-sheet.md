# 📘 Git Cheat Sheet — Commands Mapped to Intent

> **Audience**: All developers
> **Purpose**: Provide a concise, practical reference for Git commands, clearly mapped to *why* and *when* they are used.

This cheat sheet is designed to complement the conceptual documents in this repository. Commands are grouped by **intent**, not memorization.

---

## 1. Repository Setup

### Clone a Repository

Purpose: Get a full copy of a remote repository and its history.

```
git clone <repository-url>
```

Example:

```
git clone https://github.com/org/project.git
```

---

## 2. Checking Repository Status

### View Current Status

Purpose: See which files are modified, staged, or untracked.

```
git status
```

Use this command frequently.

---

## 3. Branching

### List Branches

Purpose: See available branches.

```
git branch
```

### Create a New Branch

Purpose: Start isolated work.

```
git branch feature/my-feature
```

### Switch Branches

Purpose: Move between timelines.

```
git checkout feature/my-feature
```

### Create and Switch in One Step

```
git checkout -b feature/my-feature
```

---

## 4. Making Changes

### Stage All Changes

Purpose: Prepare all modified files for commit.

```
git add .
```

### Stage Specific File

```
git add <file>
```

---

## 5. Committing

### Commit Staged Changes

Purpose: Save a snapshot to history.

```
git commit -m "Descriptive commit message"
```

---

## 6. Viewing History

### View Full History

```
git log
```

### Compact History

```
git log --oneline
```

---

## 7. Working With Remotes

### List Remotes

```
git remote -v
```

### Add Remote

```
git remote add origin <url>
```

---

## 8. Syncing Changes

### Pull Latest Changes

Purpose: Fetch and merge updates from remote.

```
git pull origin main
```

### Fetch Without Merging

Purpose: See remote updates safely.

```
git fetch
```

---

## 9. Pushing Changes

### Push Branch to Remote

Purpose: Share your work.

```
git push origin feature/my-feature
```

---

## 10. Merging

### Merge Branch Into Current Branch

Purpose: Combine histories.

```
git merge feature/my-feature
```

---

## 11. Merge Conflicts

### Abort a Merge

Purpose: Exit merge safely.

```
git merge --abort
```

---

## 12. Undoing Changes

### Discard Local Changes

```
git checkout -- <file>
```

### Unstage File

```
git reset <file>
```

---

## 13. Reset and Revert

### Revert a Commit (Safe)

Purpose: Undo via new commit.

```
git revert <commit-sha>
```

### Reset (Dangerous on Shared Branches)

```
git reset --hard <commit-sha>
```

---

## 14. Rebasing

### Rebase Current Branch

Purpose: Reapply commits onto another branch.

```
git rebase main
```

⚠️ Never rebase shared branches.

---

## 15. Cherry-Picking

### Apply Specific Commit

```
git cherry-pick <commit-sha>
```

---

## 16. Tags and Releases

### Create a Tag

```
git tag v1.0.0
```

### Push Tags

```
git push origin --tags
```

---

## 17. Cleaning Up

### Delete Local Branch

```
git branch -d feature/my-feature
```

### Delete Remote Branch

```
git push origin --delete feature/my-feature
```

---

## 18. Emergency Commands

### Stash Changes

Purpose: Temporarily save work.

```
git stash
```

### Apply Stash

```
git stash pop
```

---

## 19. Daily Professional Workflow (Summary)

```
status → add → commit → push → PR → review → merge
```

---

## 20. Senior Engineer Reminder

* Commands are tools
* Intent matters more than syntax
* Protect main
* Keep history clean

---

**End of git-cheat-sheet.md**
