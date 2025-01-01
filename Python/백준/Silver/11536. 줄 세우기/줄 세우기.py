a = int(input())
aa =[]
for i in range(a):
    aa.append(input())
bb = sorted(aa)
cc = list(reversed(bb))
ck = 0
for i in range(a):
    if aa[i]!=bb[i]:
        break
    if i==a-1:
        print('INCREASING')
        ck = 1
if (ck==0):
    for i in range(a):
        if aa[i]!=cc[i]:
            break
        if i==a-1:
            print('DECREASING')
            ck=1
if (ck==0):
    print('NEITHER')