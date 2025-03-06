t = int(input())
n1 = 100
n2 = 100
for i in range(t):
    a,b = map(int,input().split())
    if a<b:
        n1-=b
    elif a>b:
        n2-=a
print(n1)
print(n2)