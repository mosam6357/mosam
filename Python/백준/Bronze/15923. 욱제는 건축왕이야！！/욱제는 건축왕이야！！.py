t = int(input())
total = 0
for i in range(t):
    if i==0:
        a,b = map(int,input().split())
        p1 = a; p2 = b
    else:
        c,d = map(int,input().split())
        total+=abs(a-c)+abs(b-d)
        a = c; b= d
    if i==t-1:
        total+=abs(p1-c)+abs(p2-d)
print(total)