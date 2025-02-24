def choice(level):
    if level==m:
            print(*path)
            return
    for i in range(n):
        if used[i]==0:
            path[level]=aa[i]
            used[i]=1
            choice(level+1)
            used[i]=0
            

n,m = map(int,input().split())
aa = [x for x in range(1,n+1)]
used = [0]*n
path = [0]*m
choice(0)