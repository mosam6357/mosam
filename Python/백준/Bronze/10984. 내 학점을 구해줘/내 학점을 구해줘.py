t = int(input())
for i in range(t):
    a = int(input())
    total = 0
    n = 0
    for j in range(a):
        q,w = map(float,input().split())
        total+=q*w
        n+=q
    print(int(n),total/n)