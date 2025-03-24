a,b,c =map(int,input().split())
if a%2==b%2 and b%2==c%2:
    print(a*b*c)
else:
    n = 1
    if (a%2==1):
        n*=a
    if (b%2==1):
        n*=b
    if (c%2==1):
        n*=c
    print(n)