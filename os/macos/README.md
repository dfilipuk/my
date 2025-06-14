# macOS cheat sheet

## Shortcuts

### General

Shortcut | Description
---------|------------
`Cmd + ,` | Settings
`Ctrl + D` | Next workspace
`Ctrl + A` | Previous workspace

### Finder

Shortcut | Description
---------|------------
`Cmd + O` | Open
`Cmd + T` | New tab
`Cmd + N` | New window
`Ctrl + Shift + K` | Send to Keka
`Ctrl + Shift + X` | Extract with Keka
`Ctrl + Shift + C` | Compress with Keka
`Ctrl + Shift + T` | New iTerm2 window here
`Ctrl + Opt + Shift + T` | New iTerm2 tab here
`Ctrl + Shift + V` | New VSCode window here
`Ctrl + Opt + Shift + V` | New VSCode tab here

### Mail

Shortcut | Description
---------|------------
`Cmd + Shift + N` | Get new mail

### iTerm2

Shortcut | Description
---------|------------
`Cmd + N` | New window
`Cmd + T` | New tab
`Cmd + D` | Split vertically
`Cmd + Shift + D` | Split horizontally
`Cmd + W` | Close pane
`Cmd + Opt + W` | Close all panes in tab
`Cmd + Shift + W` | Close window

### fzf

Shortcut | Description
---------|------------
`Opt + C` | `cd` into the selected directory
`Ctrl + R` | Paste the selected command from history onto the command-line
`Ctrl + T` | Paste the selected files and directories onto the command-line
`Shift + Right` | Toggle preview
`Shift + Up` | Preview up
`Shift + Down` | Preview down
`Ctrl + F` | Preview page forward (down)
`Ctrl + B` | Preview page backward (up)
`Tab` / `Shift + Tab` | Select multiple files

## Setup

### Automator

Services located in `~/Library/Services`

- `Quick Action`
    - Set `Service receives selected` to `files or folders` in `Finder`
    - Add a `Run Shell Script` action
        - Set the script action
        - Set `Pass input` to `as arguments`

### iTerm2

- `Preferences` -> `General` -> `Preferences`
    - `Load preferences from a custom folder or URL`
    - `Save changes` -> `Manually`

### fzf

- Define `fzf` env variables in `~/.zshenv`

### Zsh

- Add `[ -f ~/functions.zsh ] && source ~/functions.zsh` into `~/.zshrc`

### Oh My Zsh

#### Theme

- Put theme into `~/.oh-my-zsh/custom/themes`
- Set `ZSH_THEME` variable in `~/.zshrc`

#### Plugins

- Set `plugins` variable in `~/.zshrc`

### Spotlight

- Exclude drive from Spotlight indexing: `cd <drive_root> && touch .metadata_never_index`

## System

### Startup & background items

- `~/Library/`
    - `LaunchAgents/`
- `/Library/`
    - `LaunchAgents/`
    - `LaunchDaemons/`
    - `StartupItems/`
- `/System/Library/`
    - `LaunchAgents/`
    - `LaunchDaemons/`
    - `StartupItems/`

### Wallpapers

#### Location

- `~/Library/Application Support/com.apple.mobileAssetDesktop/`
- `/Library/Application Support/com.apple.idleassetsd/Customer/`

#### Cache

- `/private/var/folders/<xx>/<xxx...yyy>/C/`
    - `com.apple.desktoppicture/`
    - `com.apple.wallpaper.caches/`
