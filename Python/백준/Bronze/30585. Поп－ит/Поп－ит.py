a,b = map(int,input().split())
zsum = 0
osum = 0
for i in range(a):
    s = input()
    zsum+=s.count('0')
    osum+=s.count('1')
if(zsum<osum):
    print(zsum)
else:
    print(osum)