a = int(input())
for i in range(a):
    y,x,b = map(int,input().split())
    aa = [[0 for q in range(x)] for w in range(y)]
    for j in range(b):
        yy,xx = map(int,input().split())
        aa[yy][xx] = 1
    cnt = 0
    min = 0
    if x<y:
        min = x
    else:
        min = y
    for j in range(min):
        for q in range(y-j):
            for w in range(x-j):
                bb = []
                for e in range(j+1):
                    for r in range(j+1):
                        bb.append(aa[q+e][w+r])
                if bb.count(1)==0:
                    cnt+=1
    print(f"Case #{i+1}: {cnt}")