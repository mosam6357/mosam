def check(ck):
    while(True):
        if(ck==a):
            ck=1
        else:
            ck+=1
        if(dict[ck]==1):
            aa.append(ck)
            dict[ck]=0
            return ck

a,b = map(int,input().split())
dict = {}
aa=[]
ck = 0
for i in range(a):
    dict[i+1]=1
for i in range(a):
    cnt=0
    while(cnt<b):
        ck+=1
        if(ck>a):
            ck=1
        if(dict[ck]==1):
            cnt+=1
    if(dict[ck]==1):
        aa.append(ck)
        dict[ck]=0
    else:
        ck = check(ck)
print("<",end = "")
for i in range(a):
    if(i==a-1):
        print(f"{aa[i]}",end="")
    else:
        print(f"{aa[i]}, ",end="")
print(">",end = "")