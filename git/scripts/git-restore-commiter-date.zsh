#!/bin/zsh

git filter-repo --replace-refs delete-no-add --commit-callback '
if commit.committer_date != commit.author_date:
    commit.committer_date = commit.author_date
'