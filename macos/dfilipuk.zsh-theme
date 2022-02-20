prompt_context() {
  echo -n "%{$FG[215]%}%n%{$FG[247]%}@%{$FG[033]%}%m%{$reset_color%} "
}

PROMPT='$(prompt_context) %{$fg_bold[cyan]%}%~%{$reset_color%} $(git_prompt_info)'
RPROMPT='$(battery_pct_prompt)%{$fg[cyan]%}[%*]%{$reset_color%}'

ZSH_THEME_GIT_PROMPT_PREFIX="%{$fg_bold[yellow]%}"
ZSH_THEME_GIT_PROMPT_SUFFIX="%{$reset_color%} "
ZSH_THEME_GIT_PROMPT_DIRTY="%{$fg_bold[red]%}✗"
ZSH_THEME_GIT_PROMPT_CLEAN="%{$fg_bold[green]%}✓"
