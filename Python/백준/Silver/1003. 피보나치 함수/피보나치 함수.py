a = int(input())
aa=[[1,0],[0,1]]
for i in range(a):
    b = int(input())
    if(b<len(aa)):
        print(*aa[b])
    else:
        for j in range(len(aa),b+1):
            aa.append([aa[j-2][0]+aa[j-1][0],aa[j-2][1]+aa[j-1][1]])
        print(*aa[b])