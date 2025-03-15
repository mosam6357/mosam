a,b = map(int,input().split())
aa = list(map(int,input().split()))
cnt = 0
for i in aa:
    b-=i
    if b<0:
        break
    cnt+=1
print(cnt)