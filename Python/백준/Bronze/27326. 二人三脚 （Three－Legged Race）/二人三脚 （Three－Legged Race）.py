a = int(input())
aa = list(map(int,input().split()))
bb = {}
for i in aa:
    if i in bb.keys():
        bb[i]+=1
    else:
        bb[i]=1
for i in bb.keys():
    if bb[i]==1:
        print(i)