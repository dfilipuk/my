bsize () {
    if [[ $2 = r ]]; then
        du -h -d 1 $1
        else
        du -sh $1
    fi
}