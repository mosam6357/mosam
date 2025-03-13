a,b,c,d = map(int,input().split())
aa = list(map(int,input().split()))
for x in aa:
    cnt=0
    if (x%(a+b)<=a and x%(a+b)!=0):
        cnt+=1
    if (x%(c+d)<=c and x%(c+d)!=0):
        cnt+=1
    print(cnt)