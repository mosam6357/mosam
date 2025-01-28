a = int(input())
aa = list(map(int,input().split()))
s = 0
for i in aa:
    if i%2==0:
        s+=i//2
    else:
        s+=(i+1)//2
print(s)