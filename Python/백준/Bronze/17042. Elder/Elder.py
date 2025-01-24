m = input()
a = int(input())
aa = {m,}
for i in range(a):
    x,y = input().split()
    if m==y:
        aa.add(x)
        m=x
print(m)
print(len(aa))