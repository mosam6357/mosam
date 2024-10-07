a=int(input()); aa = list(map(int,input().split())); bb=[]
for i in range(a):
    if aa[i]<250:
        bb.append(4)
    elif aa[i]<275:
        bb.append(3)
    elif aa[i]<300:
        bb.append(2)
    else:
        bb.append(1)
print(*bb)