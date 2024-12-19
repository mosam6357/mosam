a,b = map(int,input().split())
ck = 1
for i in range(a):
    aa = input().split()
    if aa.count('A')!=1:
        ck = 0
if ck:
    print('Yes')
else:
    print('No')