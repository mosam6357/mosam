t,l,n = map(int,input().split())
s = 0
aa = []
bb = [0]
for i in range(n):
    bb.append(int(input()))
    s = bb[i+1]-bb[i]
    aa.append(s)
aa.append(l-bb[n])
if (max(aa)>=t):
    print('Y')
else:
    print('N')