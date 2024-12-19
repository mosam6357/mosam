a = int(input())
aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
cnt = 0
for i in range(a):
    if(bb[i]>=aa[i]):
        cnt+=1
print(cnt)