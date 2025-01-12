n,t = map(int,input().split())
aa =[0 for i in range(n)]
for i in range(t):
    a,b = map(int,input().split())
    for j in range(a-1,n,b):
        aa[j]=1
print(aa.count(0))