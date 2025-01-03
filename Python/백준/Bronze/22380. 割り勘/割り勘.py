while(True):
    a,b = map(int,input().split())
    cost = 0
    if a==0:
        break
    aa = list(map(int,input().split()))
    for i in aa:
        if i>=(b//a):
            cost+=b//a
        else:
            cost+=i
    print(cost)