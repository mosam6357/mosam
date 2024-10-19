a,b,c = map(int,input().split())
if(a+b*c==a*b):
    print(0)
elif(a+b*c>a*b):
    print(1)
else:
    print(2)