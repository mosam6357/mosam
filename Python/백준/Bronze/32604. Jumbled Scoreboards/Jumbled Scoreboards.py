a=int(input())
for i in range(a):
    if(i==0):
        b,c = map(int,input().split())
    else:
        q,w = map(int,input().split())
        if(q>=b and w>=c):
            b=q
            c=w
        else:
            print('no')
            break
    if(i==a-1):
        print('yes')