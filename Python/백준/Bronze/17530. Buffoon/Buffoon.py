a = int(input())
aa = []
for i in range(a):
    aa.append(int(input()))
if aa.index(max(aa))==0:
    print('S')
else:
    print('N')