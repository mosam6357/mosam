a,b = map(int,input().split())
aa = list(map(int,input().split()))
cnt = 0
for i in range(1,a):
    if(aa[i-1]>=aa[i]+b):
        break
    elif(aa[i-1]>=aa[i]):
        cnt+=1
        aa[i]+=b
if sorted(aa)==aa:
    print(cnt)
else:
    print(-1)