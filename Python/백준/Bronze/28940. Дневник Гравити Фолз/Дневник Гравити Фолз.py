a = list(map(int,input().split()))
b = list(map(int,input().split()))
if(a[0]<b[1] or a[1]<b[2]):
    print(-1)
else:
    w = a[0]//b[1]
    h = a[1]//b[2]
    page = w*h
    if(b[0]%page==0):
        print(b[0]//page)
    else:
        print(b[0]//page+1)