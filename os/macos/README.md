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

## Setup

### Automator

Services located in `~/Library/Services`

- `Quick Action`
    - Set `Service receives selected` to `files or folders` in `Finder`
    - Add a `Run Shell Script` action
        - Set the script action
        - Set `Pass input` to `as arguments`

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
