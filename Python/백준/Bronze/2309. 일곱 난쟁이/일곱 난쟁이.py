aa = []
for i in range(9):
    aa.append(int(input()))
aa.sort()
for i in range(8):
    a=aa[i]
    aa[i]=0
    for j in range(i+1,9):
        b=aa[j]
        aa[j]=0
        if sum(aa)==100:
            break
        else:
            aa[j]=b
    if sum(aa)==100:
        break
    else:
        aa[i]=a
for i in aa:
    if i!=0:
        print(i)