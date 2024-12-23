a,b = map(int,input().split())
aa = list(map(int,input().split()))
s = 0
for i in aa:
    s+=i//b
print(s)