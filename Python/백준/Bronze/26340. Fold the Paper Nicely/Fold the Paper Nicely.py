a = int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    print(f"Data set: {aa[0]} {aa[1]} {aa[2]}")
    for j in range(aa[2]):
        if(aa[0]>aa[1]):
            aa[0]=aa[0]//2
        else:
            aa[1]=aa[1]//2
    if(aa[0]<aa[1]):
        temp = aa[0]
        aa[0] = aa[1]
        aa[1] = temp
    print(f"{aa[0]} {aa[1]}\n")