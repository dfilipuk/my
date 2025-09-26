for file in "$ZSH_CUSTOM/plugins/dzmitryf-zsh-kit/src/"*.zsh; do
  [[ -f "$file" && -r "$file" ]] && source "$file"
done