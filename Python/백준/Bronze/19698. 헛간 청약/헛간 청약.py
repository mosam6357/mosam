a,b,c,d = map(int,input().split())
s=(b//d)*(c//d)
if(s>a):
    print(a)
else:
    print(s)