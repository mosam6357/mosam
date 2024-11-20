n,a = map(int,input().split())
aa = list(map(int,input().split()))
cnt = 0
for i in aa:
    if(i<=a):
        cnt+=1
print(cnt)