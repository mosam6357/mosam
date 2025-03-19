a = int(input())
s = []
for i in range(a):
    aa = list(map(int,input().split()))
    n = 1
    for j in range(10):
        if aa[j]!=n:
            break
        n+=1
        if n==6:
            n=1
        if j==9:
            s.append(i+1)
print(*s,sep="\n")