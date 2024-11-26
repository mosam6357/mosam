a=int(input())
for i in range(a):
    b,c,d = map(int,input().split())
    if(d>c):
        print((d-c)*(b*2-1))
    else:
        print(0)