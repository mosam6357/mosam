def check(n):
    cnt = 0
    for q in range(1,n+1):
        if n%q==0:
            cnt+=1
        if cnt>2:
            return -1
    return 0

a = int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    s = 0
    for j in aa:
        k=j
        while(True):
            if check(k)==0:
                s+=k
                break
            else:
                k+=1
    print(s)