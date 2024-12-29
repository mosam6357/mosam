a,b = map(int,input().split())
c,d = map(int,input().split())
s = (a+b+c+d-1)%4
if s==0:
    print(4)
else:
    print(s)