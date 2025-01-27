a = int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    n = aa.pop(0)
    cnt = 0
    for j in range(1,14):
        for k in range(j,14):
            bb = aa[j:k+1]
            x = aa[j-1]
            y = aa[k+1]
            for q in range(k-j+1):
                if(bb[q]<=x or bb[q]<=y):
                    break
                if q==k-j:
                    cnt+=1
    print(n,cnt)             