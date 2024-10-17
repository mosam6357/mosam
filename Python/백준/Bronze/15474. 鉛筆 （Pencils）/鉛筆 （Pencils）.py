n,a,b,c,d = map(int,input().split())
if(n%a==0):
    p1 = (n//a)*b
else:
    p1 = (n//a+1)*b
if(n%c==0):
    p2 = (n//c)*d
else:
    p2 = (n//c+1)*d
if(p1<p2):
    print(p1)
else:
    print(p2)