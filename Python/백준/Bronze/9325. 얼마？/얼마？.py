t = int(input())
for i in range(t):
    total = int(input())
    n = int(input())
    for j in range(n):
        a,b = map(int,input().split())
        total+=a*b
    print(total)