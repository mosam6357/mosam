k,n = map(int,input().split())
if n==1:
    print("-1")
else:
    x = (n*k)//(n-1)
    if (x-k)*n>=x:
        print(x)
    else:
        print(x+1)