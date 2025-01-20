a = int(input())
bb = [0,0,0]
for i in range(a):
    aa = list(map(int,input().split()))
    for j in range(3):
        bb[j]+=aa[j]
    if(min(bb)>=30):
        m = min(bb)
        for j in range(3):
            bb[j]-=m
        print(m)
    else:
        print('NO')