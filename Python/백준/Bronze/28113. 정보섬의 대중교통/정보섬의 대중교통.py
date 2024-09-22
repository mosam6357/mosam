n,a,b=map(int,input().split()); ck=1
if(b<n):
    ck=0
if(b==a and ck==1):
    print("Anything")
elif(b<a and ck==1):
    print("Subway")
else:
    print("Bus")