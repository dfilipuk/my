export FZF_DEFAULT_OPTS="\
    --preview='bat --paging=never --style=numbers --color=always --line-range :500 {}' \
    --preview-window='up,85%,border-bottom,hidden,wrap' \
    --bind='shift-right:toggle-preview,shift-up:preview-up,shift-down:preview-down,ctrl-f:preview-page-down,ctrl-b:preview-page-up'
"