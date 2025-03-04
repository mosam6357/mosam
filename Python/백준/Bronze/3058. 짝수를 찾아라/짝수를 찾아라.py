t = int(input())
for i in range(t):
    aa = list(map(int,input().split()))
    bb = []
    for j in aa:
        if j%2==0:
            bb.append(j)
    print(f"{sum(bb)} {min(bb)}")