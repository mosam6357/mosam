while(True):
    n = int(input())
    if n==0:
        break
    a,b = map(int,input().split())
    for i in range(n):
        c,d =  map(int,input().split())
        if c==a or d==b:
            print('divisa')
        elif c>a and d>b:
            print('NE')
        elif c<a and d>b:
            print('NO')
        elif c<a and d<b:
            print('SO')
        elif c>a and d<b:
            print('SE')