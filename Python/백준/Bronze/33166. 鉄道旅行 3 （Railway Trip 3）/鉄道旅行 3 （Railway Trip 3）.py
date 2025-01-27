a,b = map(int,input().split())
c,d = map(int,input().split())
if b<=a:
    print(b*c)
else:
    print(a*c+(b-a)*d)