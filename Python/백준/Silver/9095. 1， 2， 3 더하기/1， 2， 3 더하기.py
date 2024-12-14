a = int(input())
aa = []
for i in range(a):
    b = int(input())
    aa.append(b)
m = max(aa)
bb = [0,1,2,4,7]
if(m>4):
    for i in range(5,m+1):
        bb.append(bb[i-1]*2-bb[i-4])
for i in range(a):
    print(bb[aa[i]])