import math

a=int(input())
if(a==4 or a==7):
    print(-1)
else:
    cnt = math.ceil(a/3)
    aa=[]
    while(cnt>=math.floor(a/5)):
        for i in range(cnt+1):
            if((3*(cnt-i)+5*(i))==a):
                aa.append(cnt)
        cnt-=1
    print(min(aa))