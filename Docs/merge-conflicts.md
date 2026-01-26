# 📘 Merge Conflicts — Understanding, Resolving, and Preventing Conflicts

> **Audience**: Developers of all levels
> **Goal**: Explain merge conflicts clearly, remove fear, and teach professional conflict resolution practices.

Merge conflicts are a **normal part of collaborative development**. This document explains *why* they happen, *how* to resolve them safely, and *how professionals minimize them*.

---

## 1. What Is a Merge Conflict?

A merge conflict occurs when Git cannot automatically combine changes from two branches.

Git does **not guess**. When intent is unclear, Git asks a human to decide.

Conflicts are not errors — they are decision points.

---

## 2. Why Merge Conflicts Happen

Conflicts usually occur when:

* Two branches modify the same file
* The same lines are changed differently
* One branch deletes code another modifies

Parallel work makes conflicts inevitable.

---

## 3. Common Conflict Scenarios

Typical real-world cases:

* Two developers edit the same method
* Feature branch diverges too long from main
* Large refactoring overlaps with feature work
* Auto-formatting touches many files

---

## 4. Git’s Perspective on Conflicts

Git works line-by-line.

If Git sees:

* Clear, non-overlapping changes → auto-merge
* Ambiguous changes → conflict

Git never decides correctness — only humans do.

---

## 5. When Conflicts Are Detected

Conflicts can appear during:

* Merging branches
* Pulling changes
* Rebasing
* Cherry-picking

All scenarios require manual resolution.

---

## 6. Conflict Markers Explained

When a conflict occurs, Git inserts markers:

```
<<<<<<< HEAD
Your changes
=======
Incoming changes
>>>>>>> branch-name
```

These markers show **both versions** of the code.

---

## 7. Resolving a Merge Conflict (High-Level)

The resolution process:

1. Open the conflicted file
2. Understand both changes
3. Decide correct logic
4. Remove conflict markers
5. Save the file
6. Commit the resolution

---

## 8. Understanding Intent Before Fixing

Professional conflict resolution starts with understanding:

* Why each change was made
* What problem each change solves
* Whether both changes are needed

Never blindly choose one side.

---

## 9. Choosing the Correct Resolution

Possible outcomes:

* Keep your changes
* Keep incoming changes
* Combine both changes
* Rewrite logic entirely

Correctness matters more than speed.

---

## 10. Testing After Conflict Resolution

After resolving conflicts:

* Build the project
* Run tests
* Verify behavior

Conflicts can introduce subtle bugs.

---

## 11. Committing Conflict Resolutions

Conflict resolutions must be committed.

Good commit messages:

* `Resolve merge conflict in order service`
* `Merge main into feature/login`

---

## 12. Merge Conflicts in Pull Requests

On GitHub:

* PRs may show “This branch has conflicts”
* Conflicts must be resolved before merge

Resolution usually happens locally.

---

## 13. Resolving PR Conflicts Safely

Recommended steps:

1. Update local main
2. Merge main into feature branch
3. Resolve conflicts locally
4. Push updates
5. PR updates automatically

---

## 14. Rebase Conflicts

Conflicts during rebase:

* Occur commit-by-commit
* Require resolution at each step

Rebase conflicts require extra care.

---

## 15. Merge vs Rebase Conflicts

| Merge               | Rebase              |
| ------------------- | ------------------- |
| One-time resolution | Repeated per commit |
| Preserves history   | Rewrites history    |

Choose based on team rules.

---

## 16. Avoiding Merge Conflicts

Best practices:

* Pull main frequently
* Keep branches short-lived
* Make small commits
* Communicate large changes

Conflicts increase with time and size.

---

## 17. Conflict Prevention Through Workflow

Healthy workflows:

* Encourage frequent merges
* Enforce small PRs
* Use code ownership

Process reduces conflict frequency.

---

## 18. Tooling for Conflict Resolution

Common tools:

* IDE merge tools
* Visual diff tools
* GitHub conflict editor

Use tools to reduce human error.

---

## 19. Conflict Resolution Anti-Patterns

Avoid:

* Accepting changes blindly
* Resolving without understanding
* Skipping tests
* Panicking

Conflicts reward calm thinking.

---

## 20. Senior Engineer Conflict Mindset

Senior engineers:

* Stay calm
* Understand intent
* Choose correctness
* Teach others

They treat conflicts as part of the system.

---

## 21. What You Should Understand After This File

You should now be able to:

* Explain why conflicts happen
* Read conflict markers
* Resolve conflicts safely
* Prevent many conflicts proactively

---

## 22. Next Steps

Proceed to:

➡️ **docs/release-process.md**

That document explains releases, tagging, and hotfixes.

---

**End of merge-conflicts.md**
