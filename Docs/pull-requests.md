# 📘 Pull Requests — Professional GitHub Collaboration Guide

> **Audience**: Developers of all levels
> **Goal**: Explain Pull Requests (PRs) in depth — what they are, why they exist, and how professionals use them on GitHub.

Pull Requests are the **heart of professional Git workflows**. They are not just a merge button — they are a collaboration, review, and quality-control system.

---

## 1. What Is a Pull Request?

A Pull Request (PR) is a request to:

* Merge changes from one branch into another
* Review those changes before merging

In most teams:

* Base branch → `main`
* Compare branch → `feature/*`, `bugfix/*`, or `hotfix/*`

---

## 2. Why Pull Requests Exist

Pull Requests exist to:

* Prevent unreviewed code from reaching production
* Enable peer review
* Share knowledge across the team
* Catch bugs early
* Enforce standards

Without PRs, teams rely on trust alone — which does not scale.

---

## 3. Pull Requests vs Direct Commits

| Direct Commits | Pull Requests         |
| -------------- | --------------------- |
| No review      | Mandatory review      |
| High risk      | Controlled risk       |
| No discussion  | Structured discussion |
| Hard to audit  | Fully auditable       |

Professional teams **do not allow direct commits to main**.

---

## 4. When to Create a Pull Request

Create a PR when:

* A logical unit of work is complete
* Code is ready for review
* Tests pass locally

Do NOT wait until:

* Multiple features are combined
* The branch becomes too large

Small PRs are safer and faster.

---

## 5. Preparing for a Pull Request

Before opening a PR:

* Sync your branch with `main`
* Resolve conflicts locally
* Ensure builds/tests pass
* Review your own changes

Treat PRs as **public communication**.

---

## 6. Creating a Pull Request on GitHub

Typical GitHub flow:

1. Push your branch to GitHub
2. Open the repository in browser
3. Click **Pull Requests** → **New Pull Request**
4. Select:

   * Base: `main`
   * Compare: your branch
5. Click **Create Pull Request**

---

## 7. Writing a Good Pull Request Title

Good titles:

* Are short and descriptive
* Explain intent
* Reference the feature or fix

Examples:

* `Add email validation to signup flow`
* `Fix race condition in payment service`

Avoid vague titles like:

* `Updates`
* `Fix`

---

## 8. Writing a Professional PR Description

A good PR description includes:

* What changed
* Why it changed
* How it was tested
* Any risks or side effects

Clear descriptions reduce review time.

---

## 9. Linking Issues to Pull Requests

PRs should be linked to issues when possible.

Benefits:

* Traceability
* Clear business context
* Better release notes

---

## 10. Assigning Reviewers

On GitHub, reviewers can be:

* Selected manually
* Automatically assigned via rules

Choose reviewers who:

* Understand the code area
* Can provide meaningful feedback

---

## 11. Approvers vs Reviewers

* **Reviewer**: Reviews code and leaves comments
* **Approver**: Explicitly approves changes

Some teams separate these roles.

---

## 12. Required Approvals

Professional repositories often require:

* 1–2 approvals minimum
* No unresolved conversations
* All checks passing

These rules are enforced via branch protection.

---

## 13. Code Review Mindset (Author)

As the author:

* Be open to feedback
* Explain decisions clearly
* Update the PR as needed

Reviews are about code quality, not personal criticism.

---

## 14. Code Review Mindset (Reviewer)

As a reviewer:

* Focus on correctness and clarity
* Ask “why” when unclear
* Suggest improvements respectfully

Avoid nitpicking unless it adds value.

---

## 15. Common Review Comments

Typical review areas:

* Business logic correctness
* Edge cases
* Performance implications
* Security concerns
* Readability

---

## 16. Responding to Review Feedback

Professional responses:

* Acknowledge comments
* Make requested changes
* Ask clarifying questions

Avoid defensive behavior.

---

## 17. Updating a Pull Request

To update a PR:

* Push new commits to the same branch
* GitHub updates the PR automatically

Do NOT open a new PR for the same work.

---

## 18. Pull Request Checks

PRs may require:

* Build success
* Test pass
* Linting
* Security scans

Failing checks block merging.

---

## 19. Merge Options on GitHub

GitHub provides three merge options:

1. **Create a merge commit**
2. **Squash and merge**
3. **Rebase and merge**

Each has different history implications.

---

## 20. When to Use Squash Merge

Squash merge is useful when:

* Feature branch has many small commits
* You want a clean main history

It creates one commit on `main`.

---

## 21. When to Use Merge Commit

Merge commits are useful when:

* Preserving full branch history matters
* Working on long-lived branches

---

## 22. When to Use Rebase and Merge

Rebase and merge:

* Creates linear history
* Rewrites commit history

Never use on shared branches unless team agrees.

---

## 23. Final Review Before Merge

Before merging, confirm:

* All approvals are present
* All checks are green
* Scope is correct

Once merged, changes affect the entire team.

---

## 24. Deleting Feature Branches

After merge:

* Delete the feature branch
* Keep repository clean

Git history is preserved even after deletion.

---

## 25. Pull Requests as Documentation

PRs serve as:

* Design records
* Decision history
* Audit trail

Well-written PRs are long-term assets.

---

## 26. Common Pull Request Mistakes

Avoid:

* Huge PRs
* Poor descriptions
* Skipping reviews
* Ignoring comments

---

## 27. Senior Engineer Role in PRs

Senior engineers:

* Model good PR behavior
* Review thoughtfully
* Improve team standards

They treat PRs as a system, not a chore.

---

## 28. What You Should Understand After This File

You should now understand:

* What a PR is
* How to create one on GitHub
* How reviews and approvals work
* How merges happen safely

---

## 29. Next Steps

Proceed to:

➡️ **docs/merge-conflicts.md**

That document explains conflicts and resolution in detail.

---

**End of pull-requests.md**
