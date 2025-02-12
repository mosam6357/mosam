a = int(input())
aa = list(map(int,input().split()))
ans = 0
for i in aa:
    b,c = map(int,input().split())
    if i==1 and b<c:
        ans += c-b
print(ans)