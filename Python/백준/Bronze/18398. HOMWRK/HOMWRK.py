a = int(input())
for i in range(a):
    b = int(input())
    for j in range(b):
        c,d = map(int,input().split())
        print(c+d,c*d)