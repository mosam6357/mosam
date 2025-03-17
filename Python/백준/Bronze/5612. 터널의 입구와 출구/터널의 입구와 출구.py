t = int(input())
n = int(input())
m = n
for i in range(t):
    a,b = map(int,input().split())
    n += a-b
    if n<0:
        m=0
        break
    elif n>m:
        m=n
print(m)