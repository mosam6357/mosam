a = int(input())
aa = list(map(int,input().split()))
cnt = 0
for i in range(1,a):
    if aa[i]>aa[i-1]:
        cnt+=1
print(cnt)