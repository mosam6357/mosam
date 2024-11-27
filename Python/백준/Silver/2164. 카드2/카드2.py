from collections import deque
a = int(input())
aa = deque([i+1 for i in range(a)])
while(len(aa)!=1):
    aa.popleft()
    aa.append(aa.popleft()) 
print(aa[0])