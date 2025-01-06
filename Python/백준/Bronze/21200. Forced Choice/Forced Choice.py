a,b,n = map(int,input().split())
for i in range(n):
    aa = list(map(int,input().split()))
    del aa[0]
    if b in aa:
        print('KEEP')
    else:
        print('REMOVE')