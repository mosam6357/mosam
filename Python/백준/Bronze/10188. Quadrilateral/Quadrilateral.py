a=int(input())
for i in range(a):
    b,c = map(int,input().split())
    for j in range(c):
        print('X'*b)
    print('')