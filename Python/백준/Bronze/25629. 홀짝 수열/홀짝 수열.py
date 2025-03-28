a = int(input())
cnt = 0
aa = list(map(int,input().split()))
for i in aa:
    if i%2==0:
        cnt+=1
    else:
        cnt-=1
if a%2==0:
    if cnt==0:
        print(1)
    else:
        print(0)
else:
    if cnt==-1:
        print(1)
    else:
        print(0)