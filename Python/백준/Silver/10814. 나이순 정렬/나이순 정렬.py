a=int(input()); aa=[]
for i in range(a):
    b,c=input().split()
    aa.append([int(b),c,i])
aa.sort(key = lambda x:(x[0],x[2]))
for i in range(a):
    print(aa[i][0],aa[i][1])