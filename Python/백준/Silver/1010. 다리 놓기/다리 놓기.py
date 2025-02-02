a = int(input())
for i in range(a):
    b,c = map(int,input().split())
    f1 = 1
    f2 = 1
    f3 = 1
    for j in range(1,c+1):
        f1*=j
    for j in range(1,b+1):
        f3*=j
    for j in range(1,c-b+1):
        f2*=j
    print(f1//(f2*f3))