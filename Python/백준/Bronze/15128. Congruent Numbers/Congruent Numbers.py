a,b,c,d = map(int,input().split())
e = (a*c)/(b*d)/2
if(e==int(e) or e-int(e)<0.0001):
    print(1)
else:
    print(0)