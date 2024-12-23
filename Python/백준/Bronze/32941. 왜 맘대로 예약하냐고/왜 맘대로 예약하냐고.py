a,b = map(int,input().split())
s = int(input())
for i in range(s):
    c = int(input())
    bb = list(map(int,input().split()))
    if b not in bb:
        print('NO')
        break
    if i==s-1:
        print('YES')
        break