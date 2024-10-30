a=int(input())
aa = list(map(int,input().split()))
cnt = 0
for i in aa:
    if a<i:
        cnt+=a
    else:
        cnt+=i
print(cnt)