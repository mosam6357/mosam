a,b,c = map(int,input().split())
c-=a
if c%b==0:
    if c//b+1<=0:
        print('X')
    else:
        print(c//b+1)
else:
    print('X')