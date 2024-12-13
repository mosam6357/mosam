a=int(input())
aa = [0,0,1,1,2,3,2]
if a in aa:
    print(aa[a])
else:
    for i in range(7,a+1):
        bb=[]
        bb.append(aa[i-1]+1)
        if(i%2==0):
            bb.append(aa[i//2]+1)
        if(i%3==0):
            bb.append(aa[i//3]+1)
        aa.append(min(bb))
    print(aa[a])