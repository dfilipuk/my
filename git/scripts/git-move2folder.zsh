#!/bin/zsh

git filter-repo \
  --replace-refs delete-no-add \
  --to-subdirectory-filter src \
  --path-rename src/README.md:README.md