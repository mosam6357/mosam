a,b = map(int,input().split())
aa=[]
for i in range(a):
    c,d = map(int,input().split())
    if(c+d<=b):
        aa.append(c)
if(len(aa)==0):
    print(-1)
else:
    print(max(aa))