a=int(input())
t=[0 for i in range(a)]
aa = list(map(int,input().split()))
for i in range(a):
    if t==0:
        t[i] = min(aa)
    else:
        t[i] = (min(aa)+t[i-1])
    aa.remove(min(aa))
print(sum(t))