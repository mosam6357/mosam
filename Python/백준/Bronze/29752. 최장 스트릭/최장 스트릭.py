a = int(input())
aa = list(map(int,input().split()))
m = []
cnt = 0
for i in aa:
    if i==0:
        m.append(cnt)
        cnt = 0
    else:
        cnt+=1
m.append(cnt)
print(max(m))