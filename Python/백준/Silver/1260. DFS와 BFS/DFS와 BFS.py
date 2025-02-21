from collections import deque

def dfs(dict,s):
    visited = []
    stack = [s]
    while(stack):
        now = stack.pop()
        if now not in visited:
            visited.append(now)
            if now in dict.keys():
                stack += sorted(list(set(dict[now])-set(visited)),reverse=True)
    return visited

def bfs(dict,s):
    visited = []
    queue = deque([s])
    while(queue):
        now = queue.popleft()
        if now not in visited:
            visited.append(now)
            if now in dict.keys():
                queue += sorted(list(set(dict[now])-set(visited)))
    return visited

a,b,s = map(int,input().split())
aa = []
d = {}
for i in range(b):
    l = list(map(int,input().split()))
    if l[0] not in d.keys():
        d[l[0]] = [l[1]]
    else:
        d[l[0]].append(l[1])
    if l[1] not in d.keys():
        d[l[1]] = [l[0]]
    else:
        d[l[1]].append(l[0])

print(*dfs(d,s))
print(*bfs(d,s))