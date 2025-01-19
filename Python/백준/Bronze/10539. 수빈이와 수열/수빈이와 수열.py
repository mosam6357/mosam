a = int(input())
aa = list(map(int,input().split()))
bb = []
avg = 0
s = 0
for i in range(a):
    avg = aa[i]
    n = avg*(i+1)-sum(bb)
    bb.append(n)
    print(n,end=" ")