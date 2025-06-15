plugins=(
    battery
    fzf
    zsh-autosuggestions
    zsh-interactive-cd
    zsh-syntax-highlighting
)

[ -f ~/.config/zshrc.d/bat.zsh ] && source ~/.config/zshrc.d/bat.zsh
[ -f ~/.config/zshrc.d/fzf.zsh ] && source ~/.config/zshrc.d/fzf.zsh
[ -f ~/.config/zshrc.d/functions.zsh ] && source ~/.config/zshrc.d/functions.zsh