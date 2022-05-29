bsize () {
    if [[ $2 = r ]]; then
        du -h -d 1 $1
        else
        du -sh $1
    fi
}

dstat () {
    if [[ $2 = r ]]; then
        local dirs=$(find $1 -type d -depth 1 | sort)
        local escapedDirs=("${(f)dirs}")
        for dir in $escapedDirs
        do
            local escapedDir=$(printf '%s' $dir)
            get_directory_statisitcs $escapedDir
        done
        else
        get_directory_statisitcs $1
    fi
}

get_directory_statisitcs () {
    find $1 -not -path '*/\.DS_Store' -ls | awk 'BEGIN {fsize = 0; fcount = 0} { if ($3 ~ /^-/) {fsize += $7; fcount += 1} else if ($3 ~ /^d/) {dcount += 1} } END {dcount -= 1; printf "\033[1;35m%5d \033[1;33m%7d \033[1;32m%15d \033[0m", dcount, fcount, fsize}'
    printf " \033[1;36m%s\033[0m\n" $1
}
