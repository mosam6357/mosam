a,b=map(int,input().split()); d=(a-b)//2; c=d+b
if(c<0 or d<0 or c+d!=a):
    print(-1)
else:
    print(f"{c} {d}")