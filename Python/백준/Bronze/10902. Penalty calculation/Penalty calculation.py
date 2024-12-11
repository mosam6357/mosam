a = int(input())
ms = 0; mt = 300; n=0
aa = []
for i in range(a):
    b,c = map(int,input().split())
    if(c>=ms):
        ms = c
    aa.append([b,c])
for i in range(a):
    if aa[i][1]>=ms and aa[i][0]<=mt:
        mt = aa[i][0]
        n=i+1
if(ms==0):
    print(0)
else:
    print(mt+(n-1)*20)