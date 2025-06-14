export FZF_DEFAULT_OPTS="\
    --preview='bat --paging=never --style=numbers --color=always --line-range :500 {}' \
    --preview-window='up,85%,border-bottom,hidden,wrap' \
    --bind='alt-space:toggle-preview,alt-up:preview-up,alt-down:preview-down,alt-f:preview-page-down,alt-b:preview-page-up'
"