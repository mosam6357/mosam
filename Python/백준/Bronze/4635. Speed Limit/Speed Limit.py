while(True):
    a = int(input())
    if a==-1:
        break
    s = 0
    d = 0
    for i in range(a):
        b,c = map(int,input().split())
        d+=b*(c-s)
        s+=(c-s)
    print(d,"miles")