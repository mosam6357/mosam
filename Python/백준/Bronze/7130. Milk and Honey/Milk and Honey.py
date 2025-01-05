a,b = map(int,input().split())
q = int(input())
s = 0
for i in range(q):
    c,d = map(int,input().split())
    if a*c>b*d:
        s+=a*c
    else:
        s+=b*d
print(s)