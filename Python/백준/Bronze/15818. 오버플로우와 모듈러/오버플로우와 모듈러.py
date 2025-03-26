a,b = map(int,input().split())
aa = list(map(int,input().split()))
n = 1
for i in aa:
    n*=i
print(n%b)