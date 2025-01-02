q = int(input())
for i in range(q):
    a,b = map(int,input().split())
    aa = list(map(int,input().split()))
    bb = list(map(int,input().split()))
    cnt = 0
    for i in aa:
        if i in bb:
            cnt+=1
    print(cnt)