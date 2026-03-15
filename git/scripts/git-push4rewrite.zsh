#!/bin/zsh

if [[ -z "$1" ]]; then
  echo "Usage: $0 <github-repo-url>"
  exit 1
fi

REPO_URL="$1"

git remote add origin "$REPO_URL"

git push --mirror --force