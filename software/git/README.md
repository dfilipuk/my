# Git

## Setup SSH key

Create `config` file in `~/.ssh` folder with content

```
Host host-alias
  HostName hostname
  User git
  IdentityFile path-to-private-key
  IdentitiesOnly yes
```

Use `host-alias` instead of hostname in URL, ex. `git clone git@host-alias:path-to-repo.git`

You want to include the option `IdentitiesOnly yes` to prevent the use of default ids. Otherwise, if you also have id files matching the default names, they will get tried first because unlike other config options (which abide by "first in wins") the `IdentityFile` option **appends** to the list of identities to try.

## Configuration

### Location

- system
  - Unix `/etc/gitconfig`
  - Windows `%ProgramFiles%\Git\mingw64\etc`
- global
  - `~/.gitconfig`
  - `~/.config/git/config`
- local
  - `[git-repositoy]/.git/config`

### Identity

- `git config [--global | --system] user.name "Name Surname"`
- `git config [--global | --system] user.email name.surname@example.com`

### Global .gitignore

`git config --global core.excludesFile '~/.gitignore'`

## Tips

### Merge strategies

`git merge branch-name -s strategy` - perform merge with specified [strategy]((https://git-scm.com/docs/merge-strategies))

### Set commiter date to author date

`git filter-branch --env-filter 'export GIT_COMMITTER_DATE="$GIT_AUTHOR_DATE"'`

### Squash merge fix

![](./squash-fix.png)