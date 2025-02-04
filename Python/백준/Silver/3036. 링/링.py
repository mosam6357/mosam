a = int(input())
aa = list(map(int,input().split()))
for i in range(a):
    if i!=0:
        b = aa[0]
        c = aa[i]
        j = 2
        while(True):
            if (b%j==0 and c%j==0):
                b//=j
                c//=j
                j=1
            if (j>=min([b,c])):
                break
            j+=1
        print(f"{b}/{c}")