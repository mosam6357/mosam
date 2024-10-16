a=int(input())
aa=list(map(float,input().split()))
s = 0
for i in range(a):
    s+=aa[i]**3
print(s**(1/3))