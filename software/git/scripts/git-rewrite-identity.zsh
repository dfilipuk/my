#!/bin/zsh

git filter-repo --replace-refs delete-no-add --commit-callback '
old_emails = {b""}
old_names = {b""}

new_name = b""
new_email = b""

if commit.author_name in old_names:
    commit.author_name = new_name
if commit.committer_name in old_names:
    commit.committer_name = new_name

if commit.author_email in old_emails:
    commit.author_email = new_email
if commit.committer_email in old_emails:
    commit.committer_email = new_email
'