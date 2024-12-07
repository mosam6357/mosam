a,b = map(int,input().split())
gm = 1
m = 2
while(m<=a and m<=b):
    if(a%m==0 and b%m==0):
        a = a//m
        b = b//m
        gm*=m
        m = 2
    else:
        m+=1
print(gm, gm*a*b)