n,m = map(int,input().split())
path = [0]*m
def permu(cnt):
    if cnt==m:
        print(*path)
        return
    for i in range(n):
        path[cnt]=i+1
        permu(cnt+1)
permu(0)