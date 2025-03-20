aa = [100, 100, 200, 200, 300, 300, 400, 400, 500]
bb = list(map(int,input().split()))
h = 0
for i in range(9):
    if aa[i]<bb[i]:
        h=1
        break
if h==1:
    print('hacker')
elif sum(bb)<100:
    print('none')
else:
    print('draw')