import sys
aa = list(map(int,sys.stdin.readline().split()))
cnt = 0
for i in aa:
    if i>0:
        cnt+=1
print(cnt)