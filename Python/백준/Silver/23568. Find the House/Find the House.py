a = int(input())
aa = []
bb = []
cc = []
for i in range(a):
    dd = input().split()
    aa.append(int(dd[0]))
    bb.append(dd[1])
    cc.append(int(dd[2]))
b = int(input())
for i in range(a):
    ind = aa.index(b)
    if bb[ind]=='L':
        b-=cc[ind]
    else:
        b+=cc[ind]
print(b)