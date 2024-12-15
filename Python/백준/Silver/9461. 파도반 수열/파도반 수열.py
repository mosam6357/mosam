a=int(input())
for i in range(a):
    b=int(input())
    aa=[0,1,1,1]
    if(b<=3):
        print(aa[b])
    else:
        for i in range(4,b+1):
            aa.append(aa[i-3]+aa[i-2])
        print(aa[b])