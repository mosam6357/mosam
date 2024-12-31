a = int(input())
aa = []
bb = []
for i in range(a):
    aa.append(int(input()))
for i in range(a):
    bb.append(int(input()))
aa.sort()
bb.sort()
s = 0
for i in range(a):
    s+=abs(aa[i]-bb[i])
print(s)