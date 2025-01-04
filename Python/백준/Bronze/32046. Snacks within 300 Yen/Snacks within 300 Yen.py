while(True):
    a = int(input())
    if a==0:
        break
    aa = list(map(int,input().split()))
    cost = 300
    for i in range(a):
        if aa[i]<=cost:
            cost-=aa[i]
    print(300-cost)