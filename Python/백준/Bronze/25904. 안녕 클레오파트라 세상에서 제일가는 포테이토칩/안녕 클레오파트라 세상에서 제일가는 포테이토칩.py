n,s = map(int,input().split())
aa = list(map(int,input().split()))
ck = 0
while(True):
    for i in range(n):
        if (s>aa[i]):
            print(i+1)
            ck=1
            break
        else:
            s+=1
    if(ck==1):
        break