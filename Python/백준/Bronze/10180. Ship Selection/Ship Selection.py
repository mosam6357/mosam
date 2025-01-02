Q = int(input())
for i in range(Q):
    q,w = map(int,input().split())
    cnt = 0
    for j in range(q):
        a,b,c = map(int,input().split())
        if w<=a*(b/c):
            cnt+=1
    print(cnt)