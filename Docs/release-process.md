# 📘 Release Process — Versioning, Tagging, Hotfixes, and Production Discipline

> **Audience**: Intermediate developers, senior engineers, tech leads
> **Goal**: Explain how professional teams release software safely using Git and GitHub.

Releasing software is **not just merging code**. It is a controlled, auditable process designed to protect users, teams, and businesses.

---

## 1. What Is a Release?

A release is:

* A specific version of the codebase
* Approved for deployment
* Traceable in history
* Reproducible at any time

A release is always tied to **a commit**.

---

## 2. Why a Formal Release Process Matters

Without a release process:

* Bugs reach production unnoticed
* Rollbacks are chaotic
* Accountability is lost
* Teams panic under pressure

A formal process provides:

* Stability
* Predictability
* Confidence
* Auditability

---

## 3. Core Release Principles

Professional release processes follow these principles:

1. **Main is always deployable**
2. **Every release is tagged**
3. **Releases are repeatable**
4. **Hotfixes follow the same discipline**

---

## 4. Release Branching Strategy (Simple & Effective)

Common enterprise approach:

```
main → production-ready
```

Releases are created directly from `main` after approval.

Some teams also use:

```
release/* → stabilization
```

This depends on scale and risk tolerance.

---

## 5. Versioning Basics

Most teams use **Semantic Versioning**:

```
MAJOR.MINOR.PATCH
```

Examples:

* `1.0.0` → first stable release
* `1.1.0` → backward-compatible feature
* `1.1.1` → bug fix only

---

## 6. When to Increment Versions

* **MAJOR**: breaking changes
* **MINOR**: new features
* **PATCH**: bug fixes

Version numbers communicate expectations.

---

## 7. Creating a Release

Typical release flow:

1. Ensure `main` is stable
2. Confirm all PRs are merged
3. Run final tests
4. Create a version tag
5. Publish the release

No unreviewed code should enter a release.

---

## 8. Git Tags

Tags:

* Point to a specific commit
* Mark a release
* Never move

Tags allow:

* Rollbacks
* Debugging old versions
* Reproducibility

---

## 9. Lightweight vs Annotated Tags

Professional teams prefer **annotated tags** because they:

* Store metadata
* Include release notes
* Are signed if needed

---

## 10. GitHub Releases

GitHub releases:

* Are built on tags
* Include release notes
* Attach binaries/artifacts

They serve as the public record of deployment.

---

## 11. Release Notes

Good release notes include:

* Summary of changes
* Bug fixes
* Breaking changes
* Migration notes

Release notes are for humans, not machines.

---

## 12. Automating Releases

Modern teams use CI/CD to:

* Build automatically
* Run tests
* Create tags
* Publish releases

Automation reduces human error.

---

## 13. Hotfixes — Emergency Releases

A hotfix is an urgent fix for production.

Characteristics:

* Time-sensitive
* Minimal scope
* High priority

---

## 14. Hotfix Workflow

```
main
 ↓
hotfix/critical-bug
 ↓
fix
 ↓
review
 ↓
merge
 ↓
tag & release
```

Speed must not eliminate discipline.

---

## 15. Merging Hotfixes

After hotfix release:

* Merge back into `main`
* Ensure future releases include the fix

Never leave hotfixes isolated.

---

## 16. Rollbacks

Rollbacks are:

* Part of professional planning
* Enabled by tags
* Preferable to risky fixes

Fast rollback > slow repair.

---

## 17. Release Failures

When a release fails:

* Stop deployments
* Roll back if needed
* Investigate calmly
* Document root cause

Blame fixes nothing. Process does.

---

## 18. Release Governance

Large teams may require:

* Release approvals
* Change windows
* Audit logs

Governance scales with risk.

---

## 19. Security in Releases

Ensure:

* Secrets are not bundled
* Dependencies are scanned
* Artifacts are trusted

Security issues are release blockers.

---

## 20. Senior Engineer Release Mindset

Senior engineers:

* Treat releases seriously
* Prefer predictable processes
* Optimize for safety
* Prepare rollback plans

Releases are business-critical moments.

---

## 21. What You Should Understand After This File

You should now understand:

* What a release is
* Why tagging matters
* How hotfixes work
* How professionals deploy safely

---

## 22. Next Steps

Proceed to:

➡️ **docs/git-cheat-sheet.md**

That document provides a concise command reference.

---

**End of release-process.md**
