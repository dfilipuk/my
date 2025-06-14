plugins=(
  battery
  colored-man-pages
  git
  macos
  themes
  vscode
  zsh-autosuggestions
  zsh-interactive-cd
  zsh-syntax-highlighting
)

[ -f ~/.config/zshrc.d/bat.zsh ] && source ~/.config/zshrc.d/bat.zsh
[ -f ~/.config/zshrc.d/fzf-opts.zsh ] && source ~/.config/zshrc.d/fzf-opts.zsh
[ -f ~/.config/zshrc.d/functions.zsh ] && source ~/.config/zshrc.d/functions.zsh