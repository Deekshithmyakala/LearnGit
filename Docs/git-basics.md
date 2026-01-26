# 📘 Git Basics — Concepts, Mental Models, and Fundamentals

> **Audience**: Absolute beginners → Senior engineers
> **Goal**: Build a rock-solid conceptual foundation of Git without relying on memorization.

This document explains **what Git is**, **why it exists**, and **how to think in Git** the way professionals do.

---

## 1. What Is Git?

Git is a **distributed version control system**.

In simple terms, Git:

* Tracks changes to files over time
* Allows multiple people to work on the same codebase safely
* Preserves history
* Enables recovery from mistakes

Git is not just a tool — it is a **system for managing change**.

---

## 2. Why Git Exists

Before Git, teams struggled with:

* Overwriting each other’s work
* Losing previous versions
* No accountability
* No reliable rollback

Git solves these problems by:

* Keeping a complete history
* Making every change traceable
* Allowing parallel work
* Providing safe undo mechanisms

---

## 3. Git vs Traditional File Backups

| File Backups     | Git                 |
| ---------------- | ------------------- |
| Manual copies    | Automatic snapshots |
| No structure     | Structured history  |
| No collaboration | Built for teams     |
| Hard to restore  | Easy rollback       |

Git understands **intent**, not just files.

---

## 4. Distributed Version Control (Very Important)

Git is **distributed**, meaning:

* Every developer has the **full history**
* No single point of failure
* You can work offline

Each local repository is a **complete backup** of the project.

---

## 5. Core Git Mental Model: Snapshots

Git does NOT track individual file changes like traditional systems.

Instead, Git stores **snapshots** of the entire project.

```
Snapshot A → Snapshot B → Snapshot C
```

Each snapshot:

* Represents the full state of the project
* Is linked to its parent snapshot
* Is immutable

These snapshots are called **commits**.

---

## 6. Repository (Repo)

A repository contains:

* Project files
* Complete history
* Branches
* Tags
* Configuration

There are two common types:

* **Local repository** (your machine)
* **Remote repository** (shared server)

---

## 7. Local Repository

The local repository:

* Lives on your machine
* Is where you experiment
* Allows mistakes safely
* Is private until shared

Professionals treat the local repo as a **sandbox**.

---

## 8. Remote Repository

The remote repository:

* Lives on a shared platform
* Is visible to the team
* Acts as the source of truth

Examples of remote platforms:

* GitHub
* GitLab
* Azure DevOps

---

## 9. Working Directory

The working directory:

* Contains your current files
* Reflects what you see in your editor
* Is NOT automatically tracked

Changes here are **uncommitted and unsafe**.

---

## 10. Staging Area (Index)

The staging area:

* Prepares changes for commit
* Represents your intent
* Allows partial commits

Think of staging as:

> “These are the changes I want to save.”

---

## 11. Repository History

Once changes are committed:

* They enter the repository history
* They are safely stored
* They can be referenced forever

Committed changes are **very hard to lose**.

---

## 12. The Three Git States

Files in Git exist in one of three states:

1. **Modified** — changed but not staged
2. **Staged** — marked for commit
3. **Committed** — saved in history

Understanding these states eliminates most Git confusion.

---

## 13. Commit

A commit is:

* A snapshot of the project
* A point in history
* A permanent record

Each commit includes:

* Files snapshot
* Author
* Timestamp
* Commit message

---

## 14. Commit Messages

Commit messages explain **why**, not just what.

Good messages:

* Are clear
* Are specific
* Use present tense

Bad messages:

* Are vague
* Combine unrelated changes
* Provide no context

---

## 15. Commit Identity (SHA)

Every commit has a unique identifier called a **SHA**.

Characteristics:

* Long hexadecimal string
* Unique across the repository
* Used to reference history

This makes Git extremely reliable.

---

## 16. HEAD

HEAD is a pointer that indicates:

* Your current position in history
* The active commit
* The active branch

Moving HEAD changes what files you see.

---

## 17. Branch

A branch is:

* A lightweight pointer to a commit
* A separate timeline

Branches allow:

* Parallel work
* Safe experimentation
* Feature isolation

Branches are cheap and encouraged.

---

## 18. Main Branch

The `main` branch represents:

* Stable code
* Production-ready state

Rules:

* No direct commits
* Always deployable
* Protected by reviews

---

## 19. Creating Branches (Conceptually)

When you create a branch:

* Git creates a new pointer
* History is shared
* No files are duplicated

This is why branches are fast.

---

## 20. Switching Branches

Switching branches:

* Moves HEAD
* Changes visible files
* Updates working directory

Git ensures safety during switching.

---

## 21. Merging Branches

Merging combines:

* Two timelines
* Two sets of changes

Git attempts automatic merges when possible.

---

## 22. Merge Conflicts (High Level)

Conflicts occur when:

* Same file
* Same lines
* Different changes

Conflicts are normal and expected.

---

## 23. Git Is Not Linear

Git history is a **graph**, not a line.

Understanding this helps with:

* Debugging
* Merging
* Reverting

---

## 24. Undo Safety

Git is designed to:

* Protect committed work
* Allow rollback
* Prevent permanent loss

If it is committed, it is almost always recoverable.

---

## 25. Professional Mindset

Professionals use Git to:

* Communicate intent
* Collaborate safely
* Reduce long-term risk

They do not fear Git — they understand it.

---

## 26. Common Beginner Misunderstandings

* Thinking Git auto-saves
* Committing everything at once
* Working directly on main
* Avoiding branches

These habits are corrected through understanding, not commands.

---

## 27. What You Should Understand After This File

You should now be able to explain:

* What Git is
* Why Git exists
* What a commit represents
* How branches work conceptually
* Why Git is safe

Commands come later.

---

## 28. Next Steps

Proceed to:

➡️ **docs/git-workflow.md**

That document explains **how Git is used daily in real teams**.

---

**End of git-basics.md**
