h,s = map(int,input().split())
for i in range(1,s+1):
    if(h%2==0):
        h = (h//2)^6
    else:
        h = (2*h)^6
print(h)