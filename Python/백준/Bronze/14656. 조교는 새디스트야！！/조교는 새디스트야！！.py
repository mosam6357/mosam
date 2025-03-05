n = int(input())
cnt = 0
aa = list(map(int,input().split()))
for i in range(len(aa)):
    if aa[i]!=i+1:
        cnt+=1
print(cnt)