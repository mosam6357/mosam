a,b = map(int,input().split())
aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
ans = 0
for i in aa:
    for j in bb:
        cc=[i,j]
        ans+=(i+j)*max(cc)
print(ans)