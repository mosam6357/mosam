a = int(input())
aa = []
s = 0
for i in range(a):
    b,c = map(int,input().split())
    s+=c-b
    aa.append(s)
print(max(aa))