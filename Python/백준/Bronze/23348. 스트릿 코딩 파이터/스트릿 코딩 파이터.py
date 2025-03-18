a,b,c = map(int,input().split())
n = int(input())
aa = []
for i in range(n):
    total = 0
    for j in range(3):
        d,e,f = map(int,input().split())
        total+=a*d+b*e+c*f
    aa.append(total)
print(max(aa))