a,b = map(str,input().split())
n1 = int(a)
n2 = int(b)
if n1>n2:
    l = len(a)
    s = len(b)
else:
    l = len(b)
    s = len(a)
aa = []
bb = []
cc = []
for i in a:
    aa.append(i)
for i in b:
    bb.append(i)
aa.reverse()
bb.reverse()
for i in range(s):
    cc.append(int(aa[i])+int(bb[i]))
for i in range(l-s):
    if n1>n2:
        cc.append(int(aa[s+i]))
    else:
        cc.append(int(bb[s+i]))
cc.reverse()
for i in cc:
    print(i,end="")
    