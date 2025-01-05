k=int(input())
a = int(input())
aa = list(map(int,input().split()))
b = int(input())
bb = list(map(int,input().split()))
m = a
cnt = 0
for i in range(a):
    for j in bb:
        if aa[i]+k==j:
            cnt+=1
print(cnt)