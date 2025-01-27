while(True):
    aa = list(map(int,input().split()))
    y = aa.pop(0)
    if y==0:
        break
    n=1
    remove = 0
    r=1
    for i in range(y):
        n*=aa[i*2]
    for i in range(y):
        remove+=r*aa[(y-i)*2-1]
        r*=aa[(y-i-1)*2]
    print(n-remove)