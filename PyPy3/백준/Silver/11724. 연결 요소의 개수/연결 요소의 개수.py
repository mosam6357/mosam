from collections import deque
import sys

a,b = map(int,sys.stdin.readline().split())
s = 0 #시작점
aa = [[] for i in range(a+1)]
for i in range(b):
    c,d = map(int,input().split())
    aa[c].append(d)
    aa[d].append(c)
    if i==b-1:
        s=d
visited = [False]*(a+1)

def bfs(aa,s):
    cnt = 0
    while visited.count(False)!=1:
        queue = deque([s])
        while queue:
            now = queue.popleft()
            if visited[now] == False:
                visited[now] = True
                for n in aa[now]:
                    if not visited[n]:
                        queue.append(n)
        cnt+=1
        for i in range(1,a+1):
            if visited[i]==False:
                s = i
                break
    return cnt

sys.stdout.write(str(bfs(aa,s)))