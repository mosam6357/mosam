a=int(input())
i=0
cnt=0
while(True):
    if(a==i):
        break
    else:
        cnt+=1
        if('50' in str(i)):
            cnt+=1
        i+=1
print(cnt)