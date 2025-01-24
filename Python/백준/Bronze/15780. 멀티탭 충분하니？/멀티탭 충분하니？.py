a,b = map(int,input().split())
s = 0
aa = list(map(int,input().split()))
for i in aa:
    s+=(i+1)//2
if(s>=a):
    print('YES')
else:
    print('NO')