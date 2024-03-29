# Windows

## Fresh install checklist

- `Settings`
    - `System`
        - `Clipboard` -> `Clipboard history` -> `On`
        - `About`
            - `Rename this PC`
            - `Advanced system settings` -> `Advanced` tab -> `Startup and recovery` -> `Settings` -> `Writing Debugging Information` -> `Small memory dump`
    - `Devices`
        - `Typing` -> `Advanced keyboard settings` -> `Let me use a different input method for each app window` -> `Off`
        - `AutoPlay` -> `Off`
    - `Personalization`
        - `Themes` -> `Desktop icon settings` -> Select icons which appear on desktop
        - `Start`
            - `Show suggestions occasionally in Start` -> `Off`
            - `Choose which folders appear on Start`
    - `Accounts` -> `Sync your settings` -> `Sync settings` -> `Off`
    - `Gaming` -> `Game Mode` -> `Use Game Mode` -> `On`
    - `Privacy` -> `Activity history` -> Set everything to `Off`
    - `Update & Security`
        - `Windows Update`
            - `Change active hours`
            - `Advanced options`
                - `Download updates over metered connections` -> `Off`
                - `Restart this device as soon as possible` -> `Off`
        - `Delivery Optimization` -> `Allow downloads from other PCs` -> `Off`
- `Control Panel` -> `System and Security` -> `Security and Maintenance` -> `Change User Account Control Settings` -> Set `Notify me only when apps try to make changes to my computer (default)`
- `File Explorer`
    - `View`
        - `Show`
            - `Hidden items`
            - `File Extensions`
        - `Options` -> `Change folder and search options`
            - `General`
                - `Open File Explorer to` -> `This PC`
                - `Show recently used files in Quick access` -> `Off`
                - `Show frequently used files in Quick access` -> `Off`
            - `View`
                - `Display the full path in the title bar` -> `On`
    - RMB on non-system volumes -> `Allow indexing` -> `Off`
- `Control` + `Shift` + `Esc` -> `Startup` -> Remove unnecessary items from autorun on startup
- `NVIDIA Control Panel` -> `Manage 3D settings` -> `Global Settings` -> `Power management mode` -> `Prefer maximum performance`

## Manual data cleanup

- Delete Google Chrome profiles
- Sign out from
    - Windows account
    - Game launchers (Steam, etc.)
    - Messengers (Skype, Telegram, etc.)
    - Other software (NVidia, VisualStudio, JetBrains, etc.)
- Delete SSH key from `~/.ssh`
- Remove all licenses
- Run `C` volume cleanup
- Cleanup `C:\Users\<username>\AppData` folder
- Delete all data on non-system volumes

## Licensing

Windows licensing could be managed with [SLMGR](https://docs.microsoft.com/en-us/windows-server/get-started/activation-slmgr-vbs-options) utility.

- `slmgr /ipk <ProductKey>` - Install a 5x5 product key
- `slmgr /ato` - Try online activation
- `slmgr /dli` - Display license information
- `slmgr /dlv` - Display detailed license information
- `slmgr /xpr` - Display the activation expiration date for the product
- `slmgr /cpky` - Remove the product key from the registry to prevent this key from being stolen by malicious code
- `slmgr /upk` - Uninstall the product key of the current Windows edition

## Tips

- `Win` + `R` -> `recent` - Recently used files, actions, etc.
- `Win` + `R` -> `msconfig` - Advanced system configuration
- Advanced startup options
    - `Shift` + `Restart`
    - `Settings` -> `Update & Security` -> `Recovery` -> `Advanced startup` -> `Restart now`