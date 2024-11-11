a,b,c,d,avg = map(int,input().split())
e = avg*4
if(a+b+c+d>=e):
    print(0)
else:
    print(e-(a+b+c+d))