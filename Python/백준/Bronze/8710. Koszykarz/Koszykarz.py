a,b,c = map(int,input().split())
if((b-a)%c==0):
    print((b-a)//c)
else:
    print((b-a)//c+1)