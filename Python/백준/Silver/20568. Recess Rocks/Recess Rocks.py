a = int(input())
b = list(map(int,input().split()))
b.sort()
cnt=0
for i in range(1,a):
    if b[i]==b[i-1]:
        cnt+=1
print(cnt)