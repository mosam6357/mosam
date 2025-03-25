a,b = map(int,input().split())
if a==0:
    print(0)
    print(0)
elif b>0 or (b<0 and a%b==0):
    print(a//b)
    print(a%b)
else:
    q = a//b+1
    print(q)
    print(a-q*b)