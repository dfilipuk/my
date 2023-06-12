bsize () {
    if [[ $2 = r ]]; then
        du -h -d 1 $1
        else
        du -sh $1
    fi
}

dstat() {
    internal_dstat $1 apfs $2
}

dstat-not-apfs() {
    internal_dstat $1 notapfs $2
}

internal_dstat () {
    if [[ $3 = r ]]; then
        local dirs=$(find $1 -type d -depth 1 | sort)
        local escapedDirs=("${(f)dirs}")
        for dir in $escapedDirs
        do
            local escapedDir=$(printf '%s' $dir)
            get_directory_statisitcs $escapedDir $2
        done
        else
        get_directory_statisitcs $1 $2
    fi
}

get_directory_statisitcs () {
    if [[ $2 = apfs ]]; then
        find $1 -not -path '*/\.DS_Store' -ls | calculate_statisitcs
        else
        find $1 -not -path '*/\.DS_Store' -not -path '*/\._*' -ls | calculate_statisitcs
    fi
    printf " \033[1;36m%s\033[0m\n" $1
}

calculate_statisitcs () {
    LC_NUMERIC=en_US.UTF-8 awk 'BEGIN {fsize = 0; fcount = 0} { if ($3 ~ /^-/) {fsize += $7; fcount += 1} else if ($3 ~ /^d/) {dcount += 1} } END {dcount -= 1; printf "\033[1;35m%\047 7d \033[1;33m%\047 10d \033[1;32m%\047 20d \033[0m", dcount, fcount, fsize}'
}