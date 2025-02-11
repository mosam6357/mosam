a = int(input())
b = int(input())
aa = []
for i in range(a,b+1):
    n1 = i**0.5
    n2 = int(n1)
    if n1==n2:
        aa.append(i)
if len(aa)==0:
    print(-1)
else:
    print(sum(aa))
    print(min(aa))