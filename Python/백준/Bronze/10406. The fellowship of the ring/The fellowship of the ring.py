a,b,n = map(int,input().split())
aa = list(map(int,input().split()))
for i in aa:
    if i<a or i>b:
        n-=1
print(n)