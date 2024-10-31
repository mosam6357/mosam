a1,a2,a3,p1,p2,p3 = map(int,input().split())
aa = [a1*p1,a2*p2,a3*p3]
for i in range(3):
    if(aa[i]==max(aa)):
        if(i==0):
            print('Joffrey ',end="")
        elif(i==1):
            print('Robb ',end="")
        else:
            print('Stannis')