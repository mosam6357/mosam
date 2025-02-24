n,m = map(int,input().split())
used = [0]*n
path = [0]*m

def permu(cnt): #순열 함수
    if cnt==m:
        if path==sorted(path):
            print(*path)
        return
    for i in range(cnt,n):
        if used[i]==0:
            used[i]=1
            path[cnt]=i+1
            permu(cnt+1)
            used[i]=0
permu(0)