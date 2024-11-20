y1,m1,d1 = map(int,input().split())
y2,m2,d2 = map(int,input().split())
if(m1<m2 or (m1==m2 and d1<=d2)):
    if(y2==y1):
        print(0)
        print(1)
    else:
        print(y2-y1)
        print(y2-y1+1)
else:
    if(y2-y1<1):
        print(0)
    else:
        print(y2-y1-1)
    print(y2-y1+1)
print(y2-y1)