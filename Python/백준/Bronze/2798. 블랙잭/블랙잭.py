n,a = map(int,input().split())
aa = list(map(int,input().split()))
ck = 0
bb = []
for i in range(n-2):
    for j in range(i+1,n):
        for k in range(j+1,n):
            s=aa[i]+aa[j]+aa[k]
            if(s<=a):
                bb.append(s)
print(max(bb))