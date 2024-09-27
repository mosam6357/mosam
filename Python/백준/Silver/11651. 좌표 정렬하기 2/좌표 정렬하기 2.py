import sys

a=int(sys.stdin.readline())
b=[]
for i in range(a):
    c,d = map(int,input().split())
    b.append([c,d])
b.sort(key=lambda x:(x[1],x[0]))
for i in range(a):
    print(*b[i])
