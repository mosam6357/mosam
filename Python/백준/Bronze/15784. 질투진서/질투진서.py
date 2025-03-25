a,b,c = map(int,input().split())
aa = []
for i in range(a):
    aa.append(list(map(int,input().split())))
me = aa[b-1][c-1]
more = 0
for i in aa[b-1]:
    if i>me:
        more=1
        break
for i in range(a):
    if aa[i][c-1]>me:
        more=1
        break
if more==1:
    print('ANGRY')
else:
    print('HAPPY')