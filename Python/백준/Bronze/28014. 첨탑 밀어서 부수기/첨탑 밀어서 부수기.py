a = int(input())
aa = list(map(int,input().split()))
cnt = 1
for i in range(1,a):
    if aa[i-1]<=aa[i]:
        cnt+=1
print(cnt)