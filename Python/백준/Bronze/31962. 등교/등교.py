a,b = map(int,input().split())
aa=[]; bb=[]
for i in range(a):
    c,d = map(int,input().split())
    if(c+d<=b):
        aa.append(c)
        bb.append(c+d)
if(len(aa)==0):
    print(-1)
else:
    q = bb.index(max(bb))
    print(aa[q])