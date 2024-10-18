a=int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    print("Denominations: ",end="")
    print(*aa[1:])
    ck=0
    for j in range(1,aa[0]):
        if(aa[j+1]<aa[j]*2):
            ck=1
            break
    if(ck==0):
        print("Good coin denominations!\n")
    else:
        print("Bad coin denominations!\n")