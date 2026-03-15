#!/bin/zsh

if [[ -z "$1" ]]; then
  echo "Usage: $0 <github-repo-url>"
  exit 1
fi

REPO_URL="$1"

echo "Cloning mirror repo to './mirror'..."
git clone --mirror "$REPO_URL" mirror

echo "Cloning backup mirror to './backup'..."
git clone --mirror "$REPO_URL" backup

echo "Cloning regular worktree to './worktree'..."
git clone "$REPO_URL" worktree