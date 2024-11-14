a,b = map(int,input().split())
cnt = 0
while(True):
    if(cnt%2==0):
        if(a!=0):
            a-=1
        else:
            break
    else:
        if(b!=0):
            b-=1
        else:
            break
    cnt+=1
if cnt%2==0:
    print(cnt-1)
else:
    print(cnt)